using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace nguyenconghau_5951071025.Models
{
    [DataContract]
    public class StudentInfo
    {
        public static List<StudentInfo> StudentInfList = new List<StudentInfo>(){
        new StudentInfo() { ID=000,HoTen="Nguyễn Công Hậu", NgaySinh="17/01/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=001,HoTen="Nguyễn Văn An", NgaySinh="23/01/2002", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=002,HoTen="Võ Văn Kha", NgaySinh="03/01/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=003,HoTen="Phạm Thị Tú", NgaySinh="17/11/2000", GioiTinh="nữ", HocVan="Đại học" },
        new StudentInfo() { ID=004,HoTen="Lê Nguyễn Thái Khang", NgaySinh="17/06/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=005,HoTen="Trần Thọ Hiền", NgaySinh="20/01/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=006,HoTen="Võ Tấn Đào", NgaySinh="15/09/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=007,HoTen="Nguyễn Nhân", NgaySinh="30/12/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=008,HoTen="Bùi Văn Mạnh", NgaySinh="21/02/2000", GioiTinh="nam", HocVan="Đại học" },
        new StudentInfo() { ID=009,HoTen="Dương Công Hậu", NgaySinh="01/01/2000", GioiTinh="nam", HocVan="Đại học" },
    };
        [DataMember(Name = "id")]
        public int ID
        {
            get; set;
        }
        [DataMember(Name = "hoten")]
        public string HoTen
        {
            get; set;
        }
        [DataMember(Name = "ngaysinh")]
        public String NgaySinh
        {
            get; set;
        }
        [DataMember(Name = "gioitinh")]
        public string GioiTinh
        {
            get; set;
        }
        [DataMember(Name = "hocvan")]
        public string HocVan
        {
            get; set;
        }
    }
}