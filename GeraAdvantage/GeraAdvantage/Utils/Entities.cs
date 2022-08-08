using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace GeraAdvantage.Utils
{
    internal class Entities
    {
        public enum Status { Pending, Sent_To_QA, Approved, Pending_For_NC_Closure };
        public class Grouping<K, T> : ObservableCollection<T>
        {
            public K Key { get; private set; }

            public Grouping(K key, IEnumerable<T> items)
            {
                Key = key;
                foreach (var item in items)
                    this.Items.Add(item);
            }
        }
        public class FilterDetail
        {
            public string Title { get; set; }
            public bool IsChecked { get; set; }
        }
        public class ConformityPie
        {
            public string Title { get; set; }
            public int Count { get; set; }
        }
        public class ReviewQ
        {

            public string Title { get; set; }
            public Color BGColor { get; set; }
            public string BtnText { get; set; }
        }
        public class MultileOps
        {
            public string Title { get; set; }
            public bool isfour { get; set; }
            public bool isthree { get; set; }
            public bool ConverttoNC { get; set; }
            public bool AddImage { get; set; }
            public bool SEComment { get; set; }
            public bool btnYes { get; set; }
            public bool btnNo { get; set; }
            public bool btnNA { get; set; }
            public bool btnA { get; set; }
            public bool btnAWC { get; set; }
            public bool btnR { get; set; }
           public List<ImageSource> Images { get; set; }
           public List<PlaceType> Places { get; set; }
        }
        public class PlaceType
        {
            public string Title { get; set; }
            public bool IsChecked { get; set; }
        }
        public class SampleChart
        {
            public string Name { get; set; }
            public double Number { get; set; }
        }
        public class FilterType
        {
            public string Type { get; set; }
        }
        public class Project
        {
            public string Title { get; set; }
            public int TotalNCCount { get; set; }
            public int OpenNCCount { get; set; }
            public int ClosedNCCount { get; set; }
            public string Severity { get; set; }

        }
        public class StakeHolder
        {
            public string Name { get; set; }
            public string Designation { get; set; }
        }
        public class NCHistory
        {
            public string Status { get; set; }
            public string Comment { get; set; }
            public string UpdatedBy { get; set; }
            public string UpdatedAt { get; set; }

        }
        public class Checklist
        {
            public string Title { get; set; }
            public string Building { get; set; }
            public string Floor { get; set; }
            public string Category { get; set; }
            public string CreatedBy { get; set; }
            public string UpdatedBy { get; set; }
            public Status Cstatus { get; set; }
            public string ProjDate { get; set; }
            public string Deadline { get; set; }
            public bool IsPast { get; set; }

        }
    }

    public class NC
    {
        public string Id { get; set; }
        public string NCCode { get; set; }
        public long ProjectId { get; set; }
        public bool IsPotential { get; set; }
        public long BuildingId { get; set; }
        public long FloorId { get; set; }
        public long UnitTypeId { get; set; }
        public long UnitId { get; set; }
        public long RoomTypeId { get; set; }
        public long CategoryId { get; set; }
        public long SubCategoryId { get; set; }
        public long RootCauseId { get; set; }
        public long SeverityId { get; set; }
        public long ContractorId { get; set; }
        public long EngineerId { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long StatusId { get; set; }
        public bool IsChecklistLinked { get; set; }
        public string CorrectiveAction { get; set; }
        public string PrevenctiveAction { get; set; }
        public string Image { get; set; }
    }
    public class Building
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public string Title { get; set; }
        public long ProjectId { get; set; }

        public Building( string Title_, long ProjectId_)
        {
           
            this.Title = Title_;
            this.ProjectId = ProjectId_;
        }
    }
    public class BuildingFloor
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public long FloorId { get; set; }
        public long BuildingId { get; set; }

        public BuildingFloor( long FloorId_, long BuildingId_)
        {
           
            this.FloorId = FloorId_;
            this.BuildingId = BuildingId_;
        }
    }
    public class BuildingUnit
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public long BuildingFloorId { get; set; }
        public string Title { get; set; }
        public string UnitTypeId { get; set; }

        public BuildingUnit( long BuildingFloorId_, string Title_, string UnitTypeId_)
        {
           
            this.BuildingFloorId = BuildingFloorId_;
            this.Title = Title_;
            this.UnitTypeId = UnitTypeId_;
        }
    }
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public long Id { get; set; }
        public string Title { get; set; }
        public long ParentCategoryId { get; set; }

        public Category( string Title_, long ParentCategoryId_)
        {
           
            this.Title = Title_;
            this.ParentCategoryId = ParentCategoryId_;
        }
    }
    public class City
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public string Name { get; set; }

        public City( string Name_)
        {
           
            this.Name = Name_;
        }
    }
    public class Floor
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public string Title { get; set; }
        public long FloorNo { get; set; }

        public Floor( string Title_, long FloorNo_)
        {
           
            this.Title = Title_;
            this.FloorNo = FloorNo_;
        }
    }
    public class NCStatus
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public string Title { get; set; }
        public long StatusGroupId { get; set; }

        public NCStatus( string Title_, long StatusGroupId_)
        {
           
            this.Title = Title_;
            this.StatusGroupId = StatusGroupId_;
        }
    }
    public class NCStatusRole
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public long NCStatusId { get; set; }
        public long UserRoleId { get; set; }

        public NCStatusRole( long NCStatusId_, long UserRoleId_)
        {
           
            this.NCStatusId = NCStatusId_;
            this.UserRoleId = UserRoleId_;
        }
    }

    public class Project
    {
        [PrimaryKey, AutoIncrement] 
        public long Id { get; set; }
        public string Name { get; set; }
        public long CityId { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }

        public Project( string Name_, long CityId_, string Image_, string Address_)
        {
           
            this.Name = Name_;
            this.CityId = CityId_;
            this.Image = Image_;
            this.Address = Address_;
        }
    }
}

public class ReadyRecknor
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public string CategoryId { get; set; }
    public string Title { get; set; }
    public string File { get; set; }

    public ReadyRecknor( string CategoryId_, string Title_, string File_)
    {
       
        this.CategoryId = CategoryId_;
        this.Title = Title_;
        this.File = File_;
    }
}

public class RoomType
{
    [PrimaryKey, AutoIncrement] 
    public long Id { get; set; }
    public string Title { get; set; }

    public RoomType( string Title_)
    {
       
        this.Title = Title_;
    }
}
public class RootCause
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public string Title { get; set; }

    public RootCause( string Title_)
    {
       
        this.Title = Title_;
    }
}

public class Severity
{
    [PrimaryKey, AutoIncrement] 
    public long Id { get; set; }
    public string Title { get; set; }

    public Severity( string Title_)
    {
       
        this.Title = Title_;
    }
}
public class StatusGroup
{
    [PrimaryKey, AutoIncrement] 
    public long Id { get; set; }
    public string Title { get; set; }

    public StatusGroup( string Title_)
    {
       
        this.Title = Title_;
    }
}
public class StructuralMember
{
    [PrimaryKey, AutoIncrement] 
    public long Id { get; set; }
    public string Title { get; set; }

    public StructuralMember( string Title_)
    {
       
        this.Title = Title_;
    }
}

public class UnitType
{
    [PrimaryKey, AutoIncrement] 
    public long Id { get; set; }
    public string Title { get; set; }
    public long ParentUnitTypeId { get; set; }

    public UnitType( string Title_, long ParentUnitTypeId_)
    {
       
        this.Title = Title_;
        this.ParentUnitTypeId = ParentUnitTypeId_;
    }
}
public class UnitTypeRoom
{
    [PrimaryKey, AutoIncrement] 
    public long Id { get; set; }
    public long UnitTypeId { get; set; }
    public long RoomTypeId { get; set; }

    public UnitTypeRoom( long UnitTypeId_, long RoomTypeId_)
    {
       
        this.UnitTypeId = UnitTypeId_;
        this.RoomTypeId = RoomTypeId_;
    }
}

public class UserRole
{
    [PrimaryKey, AutoIncrement]
    public long Id { get; set; }
    public string Title { get; set; }
    public UserRole()
    {

    }
    public UserRole( string Title_)
    {
       
        this.Title = Title_;
    }
}

