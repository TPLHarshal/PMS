using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS.Migrations
{
    /// <inheritdoc />
    public partial class sp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE usp_GetUser
                    @id int
                AS 
                BEGIN 
                    SELECT *
                    FROM [dbo].[User]
                    WHERE id = @id
                END
                GO
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE usp_GetALLUsers
                AS 
                BEGIN 
                    SELECT *
                    FROM [dbo].[User]
                END
                GO
            ");

            migrationBuilder.Sql(@"
		CREATE PROCEDURE usp_AddUser
                    @id int,
                    @UserId varchar(MAX),
	                @UserName  varchar(MAX),
	                @Password varchar(MAX)
	                
                AS
                BEGIN 
                    INSERT INTO [dbo].[User] ([UserId],[UserName],[Password]) 
			VALUES(@UserId ,@UserName ,@Password );
	                SELECT @id = SCOPE_IDENTITY();
                END
                GO ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE usp_UpdateUser
	            @id int,
                    @UserId varchar(MAX),
	                @UserName  varchar(MAX),
	                @Password varchar(MAX)
                AS
                BEGIN 
                    UPDATE [dbo].[User]  
	                SET 
		                [UserId] = @UserId
			      ,[UserName] = @UserName
      				,[Password] = @Password
	                WHERE id=@id;
	                SELECT @id = SCOPE_IDENTITY();
                END
                GO
            ");

            migrationBuilder.Sql(@"
                CREATE PROCEDURE usp_RemoveUser
                    @id int
                AS 
                BEGIN 
                    DELETE
                    FROM [dbo].[User]
                    WHERE id  = @id
                END
                GO	
            ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
