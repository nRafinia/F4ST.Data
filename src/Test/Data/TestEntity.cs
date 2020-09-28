﻿using F4ST.Data;
using F4ST.Data.RavenDB;
using Newtonsoft.Json;

namespace Test.Data
{
    [Table("Banks")]
    public class TestEntity : BaseDbEntity
    {
        /// <summary>
        /// کد کشور
        /// </summary>
        public int? CountryId { get; set; }
        /// <summary>
        /// عنوان بانک
        /// </summary>
        public string BankTitle { get; set; }
        /// <summary>
        /// فعال/غیرفعال
        /// </summary>
        public bool? IsActive { get; set; }

        //[IgnoreInsert, IgnoreSelect, IgnoreUpdate]
        [JsonIgnore]
        public virtual CountryEntity Country { get; set; }
    }
}