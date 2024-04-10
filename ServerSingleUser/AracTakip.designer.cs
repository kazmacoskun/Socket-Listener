﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerSingleUser
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Takip")]
	public partial class AracTakipDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTakipTablo(TakipTablo instance);
    partial void UpdateTakipTablo(TakipTablo instance);
    partial void DeleteTakipTablo(TakipTablo instance);
    partial void InsertPortPlaka(PortPlaka instance);
    partial void UpdatePortPlaka(PortPlaka instance);
    partial void DeletePortPlaka(PortPlaka instance);
    #endregion
		
		public AracTakipDataContext() : 
				base(global::ServerSingleUser.Properties.Settings.Default.TakipConnectionString2, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakipDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakipDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakipDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AracTakipDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TakipTablo> TakipTablos
		{
			get
			{
				return this.GetTable<TakipTablo>();
			}
		}
		
		public System.Data.Linq.Table<PortPlaka> PortPlakas
		{
			get
			{
				return this.GetTable<PortPlaka>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TakipTablo")]
	public partial class TakipTablo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Location_Inf;
		
		private string _PortNumber;
		
		private string _Plaka;
		
		private string _Latitude;
		
		private string _LatPos;
		
		private string _Longitude;
		
		private string _LonPos;
		
		private string _Speed;
		
		private string _Course;
		
		private System.DateTime _DateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLocation_InfChanging(int value);
    partial void OnLocation_InfChanged();
    partial void OnPortNumberChanging(string value);
    partial void OnPortNumberChanged();
    partial void OnPlakaChanging(string value);
    partial void OnPlakaChanged();
    partial void OnLatitudeChanging(string value);
    partial void OnLatitudeChanged();
    partial void OnLatPosChanging(string value);
    partial void OnLatPosChanged();
    partial void OnLongitudeChanging(string value);
    partial void OnLongitudeChanged();
    partial void OnLonPosChanging(string value);
    partial void OnLonPosChanged();
    partial void OnSpeedChanging(string value);
    partial void OnSpeedChanged();
    partial void OnCourseChanging(string value);
    partial void OnCourseChanged();
    partial void OnDateTimeChanging(System.DateTime value);
    partial void OnDateTimeChanged();
    #endregion
		
		public TakipTablo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Location Inf]", Storage="_Location_Inf", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Location_Inf
		{
			get
			{
				return this._Location_Inf;
			}
			set
			{
				if ((this._Location_Inf != value))
				{
					this.OnLocation_InfChanging(value);
					this.SendPropertyChanging();
					this._Location_Inf = value;
					this.SendPropertyChanged("Location_Inf");
					this.OnLocation_InfChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PortNumber", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string PortNumber
		{
			get
			{
				return this._PortNumber;
			}
			set
			{
				if ((this._PortNumber != value))
				{
					this.OnPortNumberChanging(value);
					this.SendPropertyChanging();
					this._PortNumber = value;
					this.SendPropertyChanged("PortNumber");
					this.OnPortNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plaka", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string Plaka
		{
			get
			{
				return this._Plaka;
			}
			set
			{
				if ((this._Plaka != value))
				{
					this.OnPlakaChanging(value);
					this.SendPropertyChanging();
					this._Plaka = value;
					this.SendPropertyChanged("Plaka");
					this.OnPlakaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Latitude", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Latitude
		{
			get
			{
				return this._Latitude;
			}
			set
			{
				if ((this._Latitude != value))
				{
					this.OnLatitudeChanging(value);
					this.SendPropertyChanging();
					this._Latitude = value;
					this.SendPropertyChanged("Latitude");
					this.OnLatitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LatPos", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string LatPos
		{
			get
			{
				return this._LatPos;
			}
			set
			{
				if ((this._LatPos != value))
				{
					this.OnLatPosChanging(value);
					this.SendPropertyChanging();
					this._LatPos = value;
					this.SendPropertyChanged("LatPos");
					this.OnLatPosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Longitude", DbType="NChar(20) NOT NULL", CanBeNull=false)]
		public string Longitude
		{
			get
			{
				return this._Longitude;
			}
			set
			{
				if ((this._Longitude != value))
				{
					this.OnLongitudeChanging(value);
					this.SendPropertyChanging();
					this._Longitude = value;
					this.SendPropertyChanged("Longitude");
					this.OnLongitudeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LonPos", DbType="NChar(2) NOT NULL", CanBeNull=false)]
		public string LonPos
		{
			get
			{
				return this._LonPos;
			}
			set
			{
				if ((this._LonPos != value))
				{
					this.OnLonPosChanging(value);
					this.SendPropertyChanging();
					this._LonPos = value;
					this.SendPropertyChanged("LonPos");
					this.OnLonPosChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Speed", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Speed
		{
			get
			{
				return this._Speed;
			}
			set
			{
				if ((this._Speed != value))
				{
					this.OnSpeedChanging(value);
					this.SendPropertyChanging();
					this._Speed = value;
					this.SendPropertyChanged("Speed");
					this.OnSpeedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Course", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string Course
		{
			get
			{
				return this._Course;
			}
			set
			{
				if ((this._Course != value))
				{
					this.OnCourseChanging(value);
					this.SendPropertyChanging();
					this._Course = value;
					this.SendPropertyChanged("Course");
					this.OnCourseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTime", DbType="DateTime NOT NULL")]
		public System.DateTime DateTime
		{
			get
			{
				return this._DateTime;
			}
			set
			{
				if ((this._DateTime != value))
				{
					this.OnDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DateTime = value;
					this.SendPropertyChanged("DateTime");
					this.OnDateTimeChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PortPlaka")]
	public partial class PortPlaka : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _PlakaID;
		
		private string _PortNumber;
		
		private string _Plaka;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPlakaIDChanging(int value);
    partial void OnPlakaIDChanged();
    partial void OnPortNumberChanging(string value);
    partial void OnPortNumberChanged();
    partial void OnPlakaChanging(string value);
    partial void OnPlakaChanged();
    #endregion
		
		public PortPlaka()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlakaID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int PlakaID
		{
			get
			{
				return this._PlakaID;
			}
			set
			{
				if ((this._PlakaID != value))
				{
					this.OnPlakaIDChanging(value);
					this.SendPropertyChanging();
					this._PlakaID = value;
					this.SendPropertyChanged("PlakaID");
					this.OnPlakaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PortNumber", DbType="NChar(6) NOT NULL", CanBeNull=false)]
		public string PortNumber
		{
			get
			{
				return this._PortNumber;
			}
			set
			{
				if ((this._PortNumber != value))
				{
					this.OnPortNumberChanging(value);
					this.SendPropertyChanging();
					this._PortNumber = value;
					this.SendPropertyChanged("PortNumber");
					this.OnPortNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Plaka", DbType="NChar(15) NOT NULL", CanBeNull=false)]
		public string Plaka
		{
			get
			{
				return this._Plaka;
			}
			set
			{
				if ((this._Plaka != value))
				{
					this.OnPlakaChanging(value);
					this.SendPropertyChanging();
					this._Plaka = value;
					this.SendPropertyChanged("Plaka");
					this.OnPlakaChanged();
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