﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MatixDatabaseLibrary
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="MATIX_GAME")]
	public partial class MatixDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertGame(Game instance);
    partial void UpdateGame(Game instance);
    partial void DeleteGame(Game instance);
    partial void InsertPlayer(Player instance);
    partial void UpdatePlayer(Player instance);
    partial void DeletePlayer(Player instance);
    partial void InsertPlayersLogin(PlayersLogin instance);
    partial void UpdatePlayersLogin(PlayersLogin instance);
    partial void DeletePlayersLogin(PlayersLogin instance);
    partial void InsertPlayersHistory(PlayersHistory instance);
    partial void UpdatePlayersHistory(PlayersHistory instance);
    partial void DeletePlayersHistory(PlayersHistory instance);
    partial void InsertGameActivity(GameActivity instance);
    partial void UpdateGameActivity(GameActivity instance);
    partial void DeleteGameActivity(GameActivity instance);
    #endregion
		
		public MatixDataDataContext() : 
				base(global::MatixDatabaseLibrary.Properties.Settings.Default.MATIX_GAMEConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MatixDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MatixDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MatixDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MatixDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Game> Games
		{
			get
			{
				return this.GetTable<Game>();
			}
		}
		
		public System.Data.Linq.Table<Player> Players
		{
			get
			{
				return this.GetTable<Player>();
			}
		}
		
		public System.Data.Linq.Table<PlayersLogin> PlayersLogins
		{
			get
			{
				return this.GetTable<PlayersLogin>();
			}
		}
		
		public System.Data.Linq.Table<PlayersHistory> PlayersHistories
		{
			get
			{
				return this.GetTable<PlayersHistory>();
			}
		}
		
		public System.Data.Linq.Table<GameActivity> GameActivities
		{
			get
			{
				return this.GetTable<GameActivity>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Games")]
	public partial class Game : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _GameId;
		
		private System.DateTime _CreateTime;
		
		private long _HorizontalPlayerId;
		
		private long _VerticalPlayerId;
		
		private System.Xml.Linq.XElement _CellsMatrix;
		
		private EntitySet<PlayersHistory> _PlayersHistories;
		
		private EntitySet<GameActivity> _GameActivities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnGameIdChanging(long value);
    partial void OnGameIdChanged();
    partial void OnCreateTimeChanging(System.DateTime value);
    partial void OnCreateTimeChanged();
    partial void OnHorizontalPlayerIdChanging(long value);
    partial void OnHorizontalPlayerIdChanged();
    partial void OnVerticalPlayerIdChanging(long value);
    partial void OnVerticalPlayerIdChanged();
    partial void OnCellsMatrixChanging(System.Xml.Linq.XElement value);
    partial void OnCellsMatrixChanged();
    #endregion
		
		public Game()
		{
			this._PlayersHistories = new EntitySet<PlayersHistory>(new Action<PlayersHistory>(this.attach_PlayersHistories), new Action<PlayersHistory>(this.detach_PlayersHistories));
			this._GameActivities = new EntitySet<GameActivity>(new Action<GameActivity>(this.attach_GameActivities), new Action<GameActivity>(this.detach_GameActivities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime NOT NULL")]
		public System.DateTime CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._CreateTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HorizontalPlayerId", DbType="BigInt NOT NULL")]
		public long HorizontalPlayerId
		{
			get
			{
				return this._HorizontalPlayerId;
			}
			set
			{
				if ((this._HorizontalPlayerId != value))
				{
					this.OnHorizontalPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._HorizontalPlayerId = value;
					this.SendPropertyChanged("HorizontalPlayerId");
					this.OnHorizontalPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerticalPlayerId", DbType="BigInt NOT NULL")]
		public long VerticalPlayerId
		{
			get
			{
				return this._VerticalPlayerId;
			}
			set
			{
				if ((this._VerticalPlayerId != value))
				{
					this.OnVerticalPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._VerticalPlayerId = value;
					this.SendPropertyChanged("VerticalPlayerId");
					this.OnVerticalPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CellsMatrix", DbType="Xml NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public System.Xml.Linq.XElement CellsMatrix
		{
			get
			{
				return this._CellsMatrix;
			}
			set
			{
				if ((this._CellsMatrix != value))
				{
					this.OnCellsMatrixChanging(value);
					this.SendPropertyChanging();
					this._CellsMatrix = value;
					this.SendPropertyChanged("CellsMatrix");
					this.OnCellsMatrixChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_PlayersHistory", Storage="_PlayersHistories", ThisKey="GameId", OtherKey="GameId")]
		public EntitySet<PlayersHistory> PlayersHistories
		{
			get
			{
				return this._PlayersHistories;
			}
			set
			{
				this._PlayersHistories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_GameActivity", Storage="_GameActivities", ThisKey="GameId", OtherKey="GameId")]
		public EntitySet<GameActivity> GameActivities
		{
			get
			{
				return this._GameActivities;
			}
			set
			{
				this._GameActivities.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PlayersHistories(PlayersHistory entity)
		{
			this.SendPropertyChanging();
			entity.Game = this;
		}
		
		private void detach_PlayersHistories(PlayersHistory entity)
		{
			this.SendPropertyChanging();
			entity.Game = null;
		}
		
		private void attach_GameActivities(GameActivity entity)
		{
			this.SendPropertyChanging();
			entity.Game = this;
		}
		
		private void detach_GameActivities(GameActivity entity)
		{
			this.SendPropertyChanging();
			entity.Game = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Players")]
	public partial class Player : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _PlayerId;
		
		private System.DateTime _CreateTime;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _NickName;
		
		private string _PasswordHash;
		
		private string _Email;
		
		private EntitySet<PlayersLogin> _PlayersLogins;
		
		private EntitySet<PlayersHistory> _PlayersHistories;
		
		private EntitySet<GameActivity> _GameActivities;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlayerIdChanging(long value);
    partial void OnPlayerIdChanged();
    partial void OnCreateTimeChanging(System.DateTime value);
    partial void OnCreateTimeChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnNickNameChanging(string value);
    partial void OnNickNameChanged();
    partial void OnPasswordHashChanging(string value);
    partial void OnPasswordHashChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Player()
		{
			this._PlayersLogins = new EntitySet<PlayersLogin>(new Action<PlayersLogin>(this.attach_PlayersLogins), new Action<PlayersLogin>(this.detach_PlayersLogins));
			this._PlayersHistories = new EntitySet<PlayersHistory>(new Action<PlayersHistory>(this.attach_PlayersHistories), new Action<PlayersHistory>(this.detach_PlayersHistories));
			this._GameActivities = new EntitySet<GameActivity>(new Action<GameActivity>(this.attach_GameActivities), new Action<GameActivity>(this.detach_GameActivities));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateTime", DbType="DateTime NOT NULL")]
		public System.DateTime CreateTime
		{
			get
			{
				return this._CreateTime;
			}
			set
			{
				if ((this._CreateTime != value))
				{
					this.OnCreateTimeChanging(value);
					this.SendPropertyChanging();
					this._CreateTime = value;
					this.SendPropertyChanged("CreateTime");
					this.OnCreateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NickName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string NickName
		{
			get
			{
				return this._NickName;
			}
			set
			{
				if ((this._NickName != value))
				{
					this.OnNickNameChanging(value);
					this.SendPropertyChanging();
					this._NickName = value;
					this.SendPropertyChanged("NickName");
					this.OnNickNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PasswordHash", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string PasswordHash
		{
			get
			{
				return this._PasswordHash;
			}
			set
			{
				if ((this._PasswordHash != value))
				{
					this.OnPasswordHashChanging(value);
					this.SendPropertyChanging();
					this._PasswordHash = value;
					this.SendPropertyChanged("PasswordHash");
					this.OnPasswordHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_PlayersLogin", Storage="_PlayersLogins", ThisKey="PlayerId", OtherKey="PlayerId")]
		public EntitySet<PlayersLogin> PlayersLogins
		{
			get
			{
				return this._PlayersLogins;
			}
			set
			{
				this._PlayersLogins.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_PlayersHistory", Storage="_PlayersHistories", ThisKey="PlayerId", OtherKey="PlayerId")]
		public EntitySet<PlayersHistory> PlayersHistories
		{
			get
			{
				return this._PlayersHistories;
			}
			set
			{
				this._PlayersHistories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_GameActivity", Storage="_GameActivities", ThisKey="PlayerId", OtherKey="PlayerId")]
		public EntitySet<GameActivity> GameActivities
		{
			get
			{
				return this._GameActivities;
			}
			set
			{
				this._GameActivities.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_PlayersLogins(PlayersLogin entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_PlayersLogins(PlayersLogin entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
		
		private void attach_PlayersHistories(PlayersHistory entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_PlayersHistories(PlayersHistory entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
		
		private void attach_GameActivities(GameActivity entity)
		{
			this.SendPropertyChanging();
			entity.Player = this;
		}
		
		private void detach_GameActivities(GameActivity entity)
		{
			this.SendPropertyChanging();
			entity.Player = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayersLogin")]
	public partial class PlayersLogin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _LoginId;
		
		private long _PlayerId;
		
		private System.DateTime _LoginTime;
		
		private string _IPAddress;
		
		private System.Nullable<System.DateTime> _LogoutTime;
		
		private string _Reason;
		
		private EntityRef<Player> _Player;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoginIdChanging(long value);
    partial void OnLoginIdChanged();
    partial void OnPlayerIdChanging(long value);
    partial void OnPlayerIdChanged();
    partial void OnLoginTimeChanging(System.DateTime value);
    partial void OnLoginTimeChanged();
    partial void OnIPAddressChanging(string value);
    partial void OnIPAddressChanged();
    partial void OnLogoutTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnLogoutTimeChanged();
    partial void OnReasonChanging(string value);
    partial void OnReasonChanged();
    #endregion
		
		public PlayersLogin()
		{
			this._Player = default(EntityRef<Player>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long LoginId
		{
			get
			{
				return this._LoginId;
			}
			set
			{
				if ((this._LoginId != value))
				{
					this.OnLoginIdChanging(value);
					this.SendPropertyChanging();
					this._LoginId = value;
					this.SendPropertyChanged("LoginId");
					this.OnLoginIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="BigInt NOT NULL")]
		public long PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoginTime", DbType="DateTime NOT NULL")]
		public System.DateTime LoginTime
		{
			get
			{
				return this._LoginTime;
			}
			set
			{
				if ((this._LoginTime != value))
				{
					this.OnLoginTimeChanging(value);
					this.SendPropertyChanging();
					this._LoginTime = value;
					this.SendPropertyChanged("LoginTime");
					this.OnLoginTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IPAddress", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string IPAddress
		{
			get
			{
				return this._IPAddress;
			}
			set
			{
				if ((this._IPAddress != value))
				{
					this.OnIPAddressChanging(value);
					this.SendPropertyChanging();
					this._IPAddress = value;
					this.SendPropertyChanged("IPAddress");
					this.OnIPAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LogoutTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> LogoutTime
		{
			get
			{
				return this._LogoutTime;
			}
			set
			{
				if ((this._LogoutTime != value))
				{
					this.OnLogoutTimeChanging(value);
					this.SendPropertyChanging();
					this._LogoutTime = value;
					this.SendPropertyChanged("LogoutTime");
					this.OnLogoutTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Reason", DbType="NVarChar(80)")]
		public string Reason
		{
			get
			{
				return this._Reason;
			}
			set
			{
				if ((this._Reason != value))
				{
					this.OnReasonChanging(value);
					this.SendPropertyChanging();
					this._Reason = value;
					this.SendPropertyChanged("Reason");
					this.OnReasonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_PlayersLogin", Storage="_Player", ThisKey="PlayerId", OtherKey="PlayerId", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.PlayersLogins.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.PlayersLogins.Add(this);
						this._PlayerId = value.PlayerId;
					}
					else
					{
						this._PlayerId = default(long);
					}
					this.SendPropertyChanged("Player");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PlayersHistory")]
	public partial class PlayersHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _HistoryId;
		
		private System.DateTime _HistoryTime;
		
		private long _PlayerId;
		
		private long _GameId;
		
		private bool _Win;
		
		private int _Score;
		
		private EntityRef<Game> _Game;
		
		private EntityRef<Player> _Player;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnHistoryIdChanging(long value);
    partial void OnHistoryIdChanged();
    partial void OnHistoryTimeChanging(System.DateTime value);
    partial void OnHistoryTimeChanged();
    partial void OnPlayerIdChanging(long value);
    partial void OnPlayerIdChanged();
    partial void OnGameIdChanging(long value);
    partial void OnGameIdChanged();
    partial void OnWinChanging(bool value);
    partial void OnWinChanged();
    partial void OnScoreChanging(int value);
    partial void OnScoreChanged();
    #endregion
		
		public PlayersHistory()
		{
			this._Game = default(EntityRef<Game>);
			this._Player = default(EntityRef<Player>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HistoryId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long HistoryId
		{
			get
			{
				return this._HistoryId;
			}
			set
			{
				if ((this._HistoryId != value))
				{
					this.OnHistoryIdChanging(value);
					this.SendPropertyChanging();
					this._HistoryId = value;
					this.SendPropertyChanged("HistoryId");
					this.OnHistoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HistoryTime", DbType="DateTime NOT NULL")]
		public System.DateTime HistoryTime
		{
			get
			{
				return this._HistoryTime;
			}
			set
			{
				if ((this._HistoryTime != value))
				{
					this.OnHistoryTimeChanging(value);
					this.SendPropertyChanging();
					this._HistoryTime = value;
					this.SendPropertyChanged("HistoryTime");
					this.OnHistoryTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="BigInt NOT NULL")]
		public long PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", DbType="BigInt NOT NULL")]
		public long GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					if (this._Game.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Win", DbType="Bit NOT NULL")]
		public bool Win
		{
			get
			{
				return this._Win;
			}
			set
			{
				if ((this._Win != value))
				{
					this.OnWinChanging(value);
					this.SendPropertyChanging();
					this._Win = value;
					this.SendPropertyChanged("Win");
					this.OnWinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Score", DbType="Int NOT NULL")]
		public int Score
		{
			get
			{
				return this._Score;
			}
			set
			{
				if ((this._Score != value))
				{
					this.OnScoreChanging(value);
					this.SendPropertyChanging();
					this._Score = value;
					this.SendPropertyChanged("Score");
					this.OnScoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_PlayersHistory", Storage="_Game", ThisKey="GameId", OtherKey="GameId", IsForeignKey=true)]
		public Game Game
		{
			get
			{
				return this._Game.Entity;
			}
			set
			{
				Game previousValue = this._Game.Entity;
				if (((previousValue != value) 
							|| (this._Game.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Game.Entity = null;
						previousValue.PlayersHistories.Remove(this);
					}
					this._Game.Entity = value;
					if ((value != null))
					{
						value.PlayersHistories.Add(this);
						this._GameId = value.GameId;
					}
					else
					{
						this._GameId = default(long);
					}
					this.SendPropertyChanged("Game");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_PlayersHistory", Storage="_Player", ThisKey="PlayerId", OtherKey="PlayerId", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.PlayersHistories.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.PlayersHistories.Add(this);
						this._PlayerId = value.PlayerId;
					}
					else
					{
						this._PlayerId = default(long);
					}
					this.SendPropertyChanged("Player");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.GameActivities")]
	public partial class GameActivity : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _ActivityId;
		
		private long _GameId;
		
		private long _PlayerId;
		
		private System.DateTime _ActivityTime;
		
		private int _CellRow;
		
		private int _CellColumn;
		
		private int _CellValue;
		
		private EntityRef<Game> _Game;
		
		private EntityRef<Player> _Player;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnActivityIdChanging(long value);
    partial void OnActivityIdChanged();
    partial void OnGameIdChanging(long value);
    partial void OnGameIdChanged();
    partial void OnPlayerIdChanging(long value);
    partial void OnPlayerIdChanged();
    partial void OnActivityTimeChanging(System.DateTime value);
    partial void OnActivityTimeChanged();
    partial void OnCellRowChanging(int value);
    partial void OnCellRowChanged();
    partial void OnCellColumnChanging(int value);
    partial void OnCellColumnChanged();
    partial void OnCellValueChanging(int value);
    partial void OnCellValueChanged();
    #endregion
		
		public GameActivity()
		{
			this._Game = default(EntityRef<Game>);
			this._Player = default(EntityRef<Player>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityId", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long ActivityId
		{
			get
			{
				return this._ActivityId;
			}
			set
			{
				if ((this._ActivityId != value))
				{
					this.OnActivityIdChanging(value);
					this.SendPropertyChanging();
					this._ActivityId = value;
					this.SendPropertyChanged("ActivityId");
					this.OnActivityIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GameId", DbType="BigInt NOT NULL")]
		public long GameId
		{
			get
			{
				return this._GameId;
			}
			set
			{
				if ((this._GameId != value))
				{
					if (this._Game.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGameIdChanging(value);
					this.SendPropertyChanging();
					this._GameId = value;
					this.SendPropertyChanged("GameId");
					this.OnGameIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlayerId", DbType="BigInt NOT NULL")]
		public long PlayerId
		{
			get
			{
				return this._PlayerId;
			}
			set
			{
				if ((this._PlayerId != value))
				{
					if (this._Player.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlayerIdChanging(value);
					this.SendPropertyChanging();
					this._PlayerId = value;
					this.SendPropertyChanged("PlayerId");
					this.OnPlayerIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivityTime", DbType="DateTime NOT NULL")]
		public System.DateTime ActivityTime
		{
			get
			{
				return this._ActivityTime;
			}
			set
			{
				if ((this._ActivityTime != value))
				{
					this.OnActivityTimeChanging(value);
					this.SendPropertyChanging();
					this._ActivityTime = value;
					this.SendPropertyChanged("ActivityTime");
					this.OnActivityTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CellRow", DbType="Int NOT NULL")]
		public int CellRow
		{
			get
			{
				return this._CellRow;
			}
			set
			{
				if ((this._CellRow != value))
				{
					this.OnCellRowChanging(value);
					this.SendPropertyChanging();
					this._CellRow = value;
					this.SendPropertyChanged("CellRow");
					this.OnCellRowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CellColumn", DbType="Int NOT NULL")]
		public int CellColumn
		{
			get
			{
				return this._CellColumn;
			}
			set
			{
				if ((this._CellColumn != value))
				{
					this.OnCellColumnChanging(value);
					this.SendPropertyChanging();
					this._CellColumn = value;
					this.SendPropertyChanged("CellColumn");
					this.OnCellColumnChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CellValue", DbType="Int NOT NULL")]
		public int CellValue
		{
			get
			{
				return this._CellValue;
			}
			set
			{
				if ((this._CellValue != value))
				{
					this.OnCellValueChanging(value);
					this.SendPropertyChanging();
					this._CellValue = value;
					this.SendPropertyChanged("CellValue");
					this.OnCellValueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Game_GameActivity", Storage="_Game", ThisKey="GameId", OtherKey="GameId", IsForeignKey=true)]
		public Game Game
		{
			get
			{
				return this._Game.Entity;
			}
			set
			{
				Game previousValue = this._Game.Entity;
				if (((previousValue != value) 
							|| (this._Game.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Game.Entity = null;
						previousValue.GameActivities.Remove(this);
					}
					this._Game.Entity = value;
					if ((value != null))
					{
						value.GameActivities.Add(this);
						this._GameId = value.GameId;
					}
					else
					{
						this._GameId = default(long);
					}
					this.SendPropertyChanged("Game");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Player_GameActivity", Storage="_Player", ThisKey="PlayerId", OtherKey="PlayerId", IsForeignKey=true)]
		public Player Player
		{
			get
			{
				return this._Player.Entity;
			}
			set
			{
				Player previousValue = this._Player.Entity;
				if (((previousValue != value) 
							|| (this._Player.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Player.Entity = null;
						previousValue.GameActivities.Remove(this);
					}
					this._Player.Entity = value;
					if ((value != null))
					{
						value.GameActivities.Add(this);
						this._PlayerId = value.PlayerId;
					}
					else
					{
						this._PlayerId = default(long);
					}
					this.SendPropertyChanged("Player");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
