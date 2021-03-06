﻿using log4net;
using MatixDatabaseLibrary;
using WcfMatixServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Xml.Serialization;
using System.IO;

namespace MatixBusinessLibrary
{
    public class MatixGameManager : IMatixBuisnessInterface
    {
        /// <summary>
        /// Class internal logger 
        /// </summary>
        private static readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Use to add salt while creating a password hash
        /// </summary>
        static string salt = "Should I use another hashing algorithm";

        /// <summary>
        /// Data Access Layer 
        /// </summary>
        MatixDataAccess matixData = null;

        /// <summary>
        /// WCF Server host 
        /// </summary>
        MatixServiceHost matixHost = null;

        /// <summary>
        /// A list of active users with their emails and nick names 
        /// </summary>
        Dictionary<string, string> userEmailToNickname = null;

        /// <summary>
        /// A Dictionary to translate nickname to email
        /// </summary>
        Dictionary<string, string> usernNiknameToEmail = null;

        /// <summary>
        /// A list of waiting players
        /// </summary>
        HashSet<string> waitingPlayers = null;

        /// <summary>
        /// A list of active games found by users email
        /// </summary>
        Dictionary<string, Game> userEmailToGamel = null;


        public MatixGameManager()
        {
            userEmailToNickname = new Dictionary<string, string>();
            usernNiknameToEmail = new Dictionary<string, string>();
            waitingPlayers = new HashSet<string>();
            matixData = new MatixDataAccess();
            userEmailToGamel = new Dictionary<string, Game>();

            matixHost = new MatixServiceHost(this, typeof(MatixWcfService));
            matixHost.Open();                       
        }

        /// <summary>
        /// Add a new player to the database 
        /// </summary>
        /// <param name="firstName">User first name</param>
        /// <param name="lastName">User last name</param>
        /// <param name="nickName">User nick name</param>
        /// <param name="email">User email address</param>
        /// <param name="password">User password</param>
        /// <returns></returns>
        public RegistrationResult AddPlayer(string firstName, string lastName, string nickName, string email, string password)
        {
            logger.Info("AddPlayer");
            
            // Generate password hash  based on the user password and some salt.           
            string passwordHash = GetHashString(password + salt);

            RegistrationResult result = new RegistrationResult();

            try
            {

                if (matixData.IsPlayerEmailExist(email))
                {
                    // Error 
                    result.Status = OperationStatusnEnum.InvalidEmail;
                }

                // Add user credentials to the database
                matixData.AddPlayer(firstName, lastName, nickName, email, passwordHash);

                result.Status = OperationStatusnEnum.Success;

            }
            catch (System.Invalid​Operation​Exception ex)
            {
                logger.ErrorFormat("AddPlayer - Exception: {0}", ex);
                result.Status = OperationStatusnEnum.Failure;
            }

            return result; 
        }

        /// <summary>
        /// Validate the user credentials and save a login record
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginResult UserLogin(string email, string password, string ipAddress)
        {
            logger.InfoFormat("UserLogin Email: {0}, Pass: {1}, Ip: {2}", email, password, ipAddress);

            LoginResult result = new LoginResult();
                      
            // Generate password hash  based on the user password and some salt.           
            string passwordHash = GetHashString(password + salt);
                       
            // checked the database that user email and password exists 
            if (matixData.CheckEmailAndPasswordHash(email, passwordHash))
            {
                // Add a login record
                if (matixData.PlayerLogin(email, passwordHash, ipAddress))
                {
                    result.Status = OperationStatusnEnum.Success;

                    string nickName;
                    if (!userEmailToNickname.TryGetValue(email, out nickName))
                    {
                        // Get it from the database
                        nickName = matixData.GetPlayerNickName(email);
                        userEmailToNickname[email] = nickName;
                    }

                    string checkEmail;
                    if(!usernNiknameToEmail.TryGetValue(nickName, out checkEmail))
                    {
                        usernNiknameToEmail[nickName] = email;
                    }

                    result.NickName = nickName;

                    // Add the player to the waiting list
                    if(waitingPlayers.Add(email))
                    {
                        logger.InfoFormat("UserLogin Email: {0} Added to the waiting list.", email);
                    }
                    else
                    {
                        logger.ErrorFormat("UserLogin Email: {0} Faile to add to the waiting list or email already there.", email);
                    }

                }
                else
                {
                    result.Status = OperationStatusnEnum.Failure;
                }
            }
            else
            {
                if(matixData.IsPlayerEmailExist(email))
                {
                    result.Status = OperationStatusnEnum.InvalidPassword;                    
                }
                else
                {
                    result.Status = OperationStatusnEnum.InvalidEmail;
                }
            }
                    
            return result;
        }

        public WaitingPlayerResult GetWaitingPlayersList(string excludedEmail)
        {
            logger.Info("GetWaitingPlayr ");

            WaitingPlayerResult result = new WaitingPlayerResult();

            foreach(string email in waitingPlayers)
            {
                if (email == excludedEmail)
                    continue;

                WaitingPlayer waitingPlayer = new WaitingPlayer();
                PlayerScoreData playerData = matixData.GetWaitingPlayerData(email);

                waitingPlayer.NickName = userEmailToNickname[email];
                waitingPlayer.TotalGames = playerData.TotalNumberOfGames;
                waitingPlayer.TotalScore = playerData.TotalScore;
                waitingPlayer.NumberOfWinnings = playerData.NumberOfWinnings;

                result.WaitingPlayerslist.Add(waitingPlayer);
            }

            WaitingPlayer waitingPlayer1 = new WaitingPlayer();          
            waitingPlayer1.NickName = "Player1";
            waitingPlayer1.TotalGames = 15;
            waitingPlayer1.TotalScore = 85;
            waitingPlayer1.NumberOfWinnings = 7;
            result.WaitingPlayerslist.Add(waitingPlayer1);

            waitingPlayer1 = new WaitingPlayer();
            waitingPlayer1.NickName = "Player2";
            waitingPlayer1.TotalGames = 150;
            waitingPlayer1.TotalScore = -6585;
            waitingPlayer1.NumberOfWinnings = 87;
            result.WaitingPlayerslist.Add(waitingPlayer1);
            
            waitingPlayer1 = new WaitingPlayer();
            waitingPlayer1.NickName = "Player__3";
            waitingPlayer1.TotalGames = 25;
            waitingPlayer1.TotalScore = 45;
            waitingPlayer1.NumberOfWinnings = 17;
            result.WaitingPlayerslist.Add(waitingPlayer1);

            result.Status = OperationStatusnEnum.Success;

            return result;
        }

        public OperationStatusnEnum StartPlayingWithPlayer(string firstEmail, string secondNickname)
        {
            //  Get second player email         
            string secondEmail;
            if(usernNiknameToEmail.TryGetValue(secondNickname, out secondEmail))
            {
                return OperationStatusnEnum.Failure;
            }

            string firstNickname;
            if (userEmailToNickname.TryGetValue(firstEmail, out firstNickname))
            {
                return OperationStatusnEnum.Failure;
            }

            // Remove players from waiting list 
            waitingPlayers.Remove(firstEmail);
            waitingPlayers.Remove(secondEmail);
            
            Task.Run(() => CreateNewGameTask(firstEmail, firstNickname, secondEmail, secondNickname));
            
            return OperationStatusnEnum.Success; ;
        }
        

        private void CreateNewGameTask(string firstEmail, string firstNickname, string secondEmail, string secondNickname)
        {
            logger.InfoFormat("CreateNewGameTask firstEmail: {0}, firstNickname: {1}, secondEmail: {2}, secondNickname: {3}", firstEmail, firstNickname, secondEmail, secondNickname);


            Game game = new Game(firstEmail, firstNickname, secondEmail, secondNickname);
            
            // Add both email addresses as keys for the same game 
            userEmailToGamel[firstEmail] = game;
            userEmailToGamel[secondEmail] = game;
            
            // Update the database 
            string xmlBoard = game.GetBoardXml();
            string horizontalEmail = game.GetHorizontalPlayerEmail();
            string verticalEmail = game.GetVerticalPlayerEmail();

            matixData.CreateNewGameTask(horizontalEmail, verticalEmail, xmlBoard);

            /// Create a task when needed and run the change 
            /// save the Game in a list and pass it to the task with the change 

            //while (playing)
            //{
            //    /// 




            //    // when game ended set playing flag to false
            //    // playing = fale;

            //}

            logger.Info("CreateNewGameTask - Task ended");

        }

        public OperationStatusnEnum SetGameAction(string email, int row, int col)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Generate hash array based on the input string using SHA256
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }

        /// <summary>
        /// Generate 64 characters hash string generate from the input string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        private string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }

     
      
    }
}
