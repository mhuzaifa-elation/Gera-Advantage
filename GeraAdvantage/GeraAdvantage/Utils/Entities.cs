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
        public class NCDisplayModel
        {
            public string Id { get; set; }
            public string Title { get; set; }
            public string Building { get; set; }
            public string Floor { get; set; }
            public string Category { get; set; }
            public string CreatedBy { get; set; }
            public string UpdatedBy { get; set; }
            public string Cstatus { get; set; }
            public string ProjDate { get; set; }
            public string Deadline { get; set; }
            public bool IsPast { get; set; }

        }
    }

    public class NC
    {
        [PrimaryKey, AutoIncrement]
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
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public long StatusId { get; set; }
        public bool IsChecklistLinked { get; set; }
        public string CorrectiveAction { get; set; }
        public string PrevenctiveAction { get; set; }
        public string Image { get; set; }
    }
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string Title { get; set; }
        public long Password { get; set; }
    }
      
    public class Building
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public string Title { get; set; }
        public long ProjectId { get; set; }

       
    }
    public class BuildingFloor
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public long FloorId { get; set; }
        public long BuildingId { get; set; }

    }
    public class BuildingUnit
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public long BuildingFloorId { get; set; }
        public string Title { get; set; }
        public long UnitTypeId { get; set; }

       
    }
    public class Category
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }
        public string Title { get; set; }
        public long ParentCategoryId { get; set; }

    }
    public class City
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public string Name { get; set; }

    }
    public class Floor
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public string Title { get; set; }
        public long FloorNo { get; set; }

    }
    public class NCStatus
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public string Title { get; set; }
        public long StatusGroupId { get; set; }

    }
    public class NCStatusRole
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public long NCStatusId { get; set; }
        public long UserRoleId { get; set; }
    }

    public class Project
    {
        [PrimaryKey, AutoIncrement] 
        public string Id { get; set; }
        public string Name { get; set; }
        public long CityId { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }

    }
}

public class ReadyRecknor
{
    [PrimaryKey, AutoIncrement]
    public string Id { get; set; }
    public string CategoryId { get; set; }
    public string Title { get; set; }
    public string File { get; set; }

}

public class RoomType
{
    [PrimaryKey, AutoIncrement] 
    public string Id { get; set; }
    public string Title { get; set; }
}
public class RootCause
{
    [PrimaryKey, AutoIncrement]
    public string Id { get; set; }
    public string Title { get; set; }
}

public class Severity
{
    [PrimaryKey, AutoIncrement] 
    public string Id { get; set; }
    public string Title { get; set; }
}
public class StatusGroup
{
    [PrimaryKey, AutoIncrement] 
    public string Id { get; set; }
    public string Title { get; set; }
}
public class StructuralMember
{
    [PrimaryKey, AutoIncrement] 
    public string Id { get; set; }
    public string Title { get; set; }
}

public class UnitType
{
    [PrimaryKey, AutoIncrement] 
    public string Id { get; set; }
    public string Title { get; set; }
    public long ParentUnitTypeId { get; set; }
}
public class UnitTypeRoom
{
    [PrimaryKey, AutoIncrement] 
    public string Id { get; set; }
    public long UnitTypeId { get; set; }
    public long RoomTypeId { get; set; }
}

public class UserRole
{
    [PrimaryKey, AutoIncrement]
    public string Id { get; set; }
    public string Title { get; set; }
}

