using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SametLibrary.Genel;
using SametLibrary.Guvenlik;
using SametLibrary.VeriTabaniIslemleri;
using System.Threading.Tasks;
using System.Data;
using System.Security.Policy;
using System.IO;

namespace AppStoneLibrary.Tables
{
    public class Project
    {
        public long ProjId { get; set; }

        public string ProjName { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime StartDate { get; set; }

        public long TotalTime { get; set; }


        private void fillFromDataRow(DataRow dr)
        {
            ProjId = GenelParser.ParseLong(dr["ProjId"].ToString());
            ProjName = dr["ProjName"].ToString();
            EndDate = GenelParser.ParseDateTime(dr["EndDate"].ToString());
            StartDate = GenelParser.ParseDateTime(dr["StartDate"].ToString());
            TotalTime = GenelParser.ParseLong(dr["TotalTime"].ToString());
        }

        public static List<long> Projects(long id)
        {
            List<long> projects = new List<long>();

            DataTable dt = Islemler.Sorgu("Select p.ProjId from Employee e, WorksOn w, Project p Where e.EmpId = @1 and e.EmpId = w.EmpId and p.ProjId=w.ProjId", new object[] { id });

            foreach (DataRow dr in dt.Rows){
                projects.Add(GenelParser.ParseLong(dr["ProjId"].ToString()));
            }


            return projects;
        }

        public static Project Getir(long id)
        {

            DataTable dt = Islemler.Sorgu("Select * from Project where ProjId = @1", new object[] { id });

            if (dt.Rows.Count > 0)
            {
                Project project = new Project();

                project.fillFromDataRow(dt.Rows[0]);

                return project;
            }
            else
                return new Project() { ProjId = -1 };
        }

        public static string projectHtml(Project project)
        {
            StringBuilder sb = new StringBuilder();

            
            sb.Append("<div class=\"card tasmayan\">");
            sb.Append("    <div class=\"card-body profile-card pt-4 d-flex flex-column align-items-center\">");
            sb.Append("<div><h1>Project Name: " + project.ProjName + "</h1></div>");
            sb.Append("<div><h1>Start Date: " + project.StartDate.ToString("d") + "</h1></div>");
            sb.Append("<div><h1>End Date: " + project.EndDate.ToString("d") + "</h1></div>");
            sb.Append("<div><h1>Total Time(day): " + project.TotalTime + "</h1></div>");
           
            sb.Append("</div>");
            sb.Append("</div>");


            return sb.ToString();
        }
    }
}
