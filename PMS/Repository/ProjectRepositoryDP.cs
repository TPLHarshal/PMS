using System.Data;
using Dapper;
using Microsoft.Build.Construction;
using Microsoft.CodeAnalysis;
using Microsoft.Data.SqlClient;
using PMS.Data;
using PMS.Models;

namespace ProjectRecord4_API.Repository
{
    public class ProjectRepositoryDP : IProjectRepository
    {
        private IDbConnection db;

        public ProjectRepositoryDP(IConfiguration configuration)
        {
            this.db = new SqlConnection(configuration.GetConnectionString("ProjectRecordConnection"));
             
        }
        public PMS.Models.Project Add(PMS.Models.Project project)
        {
            var sqlquery = "  Insert Into [dbo].[Project] ([Project_Id],[Project_Name],[Start_Time_Plan],[End_Time_Plan],[Reasons],[Type],[Division],[Category],[Priority],[Department],[Location],[Status]) Values (@Project_Id,@Project_Name,@Start_Time_Plan,@End_Time_Plan,@Reasons,@Type,@Division,@Category,@Priority,@Department,@Location,@Status);"
                            + "Select Cast(Scope_Identity() as int);";
            var id = db.Query<int>(sqlquery, project).Single();
            project.id = id;
            return project;

           
        }

        public PMS.Models.Project Find(int id)
        {
            var sqlquery = "SELECT *  FROM [dbo].[Project] Where id = @id";
            return db.Query<PMS.Models.Project>(sqlquery, new { @id = id }).Single();
        }

        public List<PMS.Models.Project> GetAll()
        {
            var sqlquery = "SELECT *  FROM [dbo].[Project]";
            return db.Query<PMS.Models.Project>(sqlquery).ToList();
            
        }

        public void Remove(int id)
        {
            var sqlquery = "Delete [dbo].[Project] Where id=@id";
            db.Execute(sqlquery, new { @id = id });

        }

        public PMS.Models.Project Update(PMS.Models.Project project)
        {
            var sqlquery = "Update [dbo].[Project]  Set Project_Id = @Project_Id ,Project_Name = @Project_Name ,Start_Time_Plan = @Start_Time_Plan ,End_Time_Plan = @End_Time_Plan ,Reasons = @Reasons ,Type = @Type ,Division = @Division ,Category = @Category ,Priority = @Priority ,Department = @Department ,Location = @Location ,Status = @Status  Where id = @id";
            db.Execute(sqlquery, project);
            return project;
        }
    }
}
