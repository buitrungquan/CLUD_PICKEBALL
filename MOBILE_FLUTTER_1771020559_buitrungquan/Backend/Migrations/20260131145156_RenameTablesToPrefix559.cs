using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PcmBackend.Migrations
{
    /// <inheritdoc />
    public partial class RenameTablesToPrefix559 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_734_Bookings_734_Bookings_ParentBookingId",
                table: "734_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Bookings_734_Courts_CourtId",
                table: "734_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Bookings_734_Members_MemberId",
                table: "734_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Bookings_734_WalletTransactions_TransactionId",
                table: "734_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Matches_734_Courts_CourtId",
                table: "734_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Matches_734_Members_Team1_Player1Id",
                table: "734_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Matches_734_Members_Team1_Player2Id",
                table: "734_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Matches_734_Members_Team2_Player1Id",
                table: "734_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Matches_734_Members_Team2_Player2Id",
                table: "734_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Matches_734_Tournaments_TournamentId",
                table: "734_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Members_AspNetUsers_UserId",
                table: "734_Members");

            migrationBuilder.DropForeignKey(
                name: "FK_734_News_734_Members_CreatedByMemberId",
                table: "734_News");

            migrationBuilder.DropForeignKey(
                name: "FK_734_Notifications_734_Members_ReceiverId",
                table: "734_Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_734_TournamentParticipants_734_Members_MemberId",
                table: "734_TournamentParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_734_TournamentParticipants_734_Members_PartnerId",
                table: "734_TournamentParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_734_TournamentParticipants_734_Tournaments_TournamentId",
                table: "734_TournamentParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_734_WalletTransactions_734_Members_MemberId",
                table: "734_WalletTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_WalletTransactions",
                table: "734_WalletTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_TransactionCategories",
                table: "734_TransactionCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_Tournaments",
                table: "734_Tournaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_TournamentParticipants",
                table: "734_TournamentParticipants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_Notifications",
                table: "734_Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_News",
                table: "734_News");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_Members",
                table: "734_Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_Matches",
                table: "734_Matches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_Courts",
                table: "734_Courts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_734_Bookings",
                table: "734_Bookings");

            migrationBuilder.RenameTable(
                name: "734_WalletTransactions",
                newName: "559_WalletTransactions");

            migrationBuilder.RenameTable(
                name: "734_TransactionCategories",
                newName: "559_TransactionCategories");

            migrationBuilder.RenameTable(
                name: "734_Tournaments",
                newName: "559_Tournaments");

            migrationBuilder.RenameTable(
                name: "734_TournamentParticipants",
                newName: "559_TournamentParticipants");

            migrationBuilder.RenameTable(
                name: "734_Notifications",
                newName: "559_Notifications");

            migrationBuilder.RenameTable(
                name: "734_News",
                newName: "559_News");

            migrationBuilder.RenameTable(
                name: "734_Members",
                newName: "559_Members");

            migrationBuilder.RenameTable(
                name: "734_Matches",
                newName: "559_Matches");

            migrationBuilder.RenameTable(
                name: "734_Courts",
                newName: "559_Courts");

            migrationBuilder.RenameTable(
                name: "734_Bookings",
                newName: "559_Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_734_WalletTransactions_MemberId",
                table: "559_WalletTransactions",
                newName: "IX_559_WalletTransactions_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_734_TournamentParticipants_TournamentId",
                table: "559_TournamentParticipants",
                newName: "IX_559_TournamentParticipants_TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_734_TournamentParticipants_PartnerId",
                table: "559_TournamentParticipants",
                newName: "IX_559_TournamentParticipants_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_734_TournamentParticipants_MemberId",
                table: "559_TournamentParticipants",
                newName: "IX_559_TournamentParticipants_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Notifications_ReceiverId_IsRead",
                table: "559_Notifications",
                newName: "IX_559_Notifications_ReceiverId_IsRead");

            migrationBuilder.RenameIndex(
                name: "IX_734_News_CreatedByMemberId",
                table: "559_News",
                newName: "IX_559_News_CreatedByMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Members_UserId",
                table: "559_Members",
                newName: "IX_559_Members_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Matches_TournamentId",
                table: "559_Matches",
                newName: "IX_559_Matches_TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Matches_Team2_Player2Id",
                table: "559_Matches",
                newName: "IX_559_Matches_Team2_Player2Id");

            migrationBuilder.RenameIndex(
                name: "IX_734_Matches_Team2_Player1Id",
                table: "559_Matches",
                newName: "IX_559_Matches_Team2_Player1Id");

            migrationBuilder.RenameIndex(
                name: "IX_734_Matches_Team1_Player2Id",
                table: "559_Matches",
                newName: "IX_559_Matches_Team1_Player2Id");

            migrationBuilder.RenameIndex(
                name: "IX_734_Matches_Team1_Player1Id",
                table: "559_Matches",
                newName: "IX_559_Matches_Team1_Player1Id");

            migrationBuilder.RenameIndex(
                name: "IX_734_Matches_CourtId",
                table: "559_Matches",
                newName: "IX_559_Matches_CourtId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Bookings_TransactionId",
                table: "559_Bookings",
                newName: "IX_559_Bookings_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Bookings_ParentBookingId",
                table: "559_Bookings",
                newName: "IX_559_Bookings_ParentBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Bookings_MemberId",
                table: "559_Bookings",
                newName: "IX_559_Bookings_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_734_Bookings_CourtId_StartTime_EndTime",
                table: "559_Bookings",
                newName: "IX_559_Bookings_CourtId_StartTime_EndTime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_WalletTransactions",
                table: "559_WalletTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_TransactionCategories",
                table: "559_TransactionCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_Tournaments",
                table: "559_Tournaments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_TournamentParticipants",
                table: "559_TournamentParticipants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_Notifications",
                table: "559_Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_News",
                table: "559_News",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_Members",
                table: "559_Members",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_Matches",
                table: "559_Matches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_Courts",
                table: "559_Courts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_559_Bookings",
                table: "559_Bookings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_559_Bookings_559_Bookings_ParentBookingId",
                table: "559_Bookings",
                column: "ParentBookingId",
                principalTable: "559_Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Bookings_559_Courts_CourtId",
                table: "559_Bookings",
                column: "CourtId",
                principalTable: "559_Courts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Bookings_559_Members_MemberId",
                table: "559_Bookings",
                column: "MemberId",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Bookings_559_WalletTransactions_TransactionId",
                table: "559_Bookings",
                column: "TransactionId",
                principalTable: "559_WalletTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_559_Matches_559_Courts_CourtId",
                table: "559_Matches",
                column: "CourtId",
                principalTable: "559_Courts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_559_Matches_559_Members_Team1_Player1Id",
                table: "559_Matches",
                column: "Team1_Player1Id",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Matches_559_Members_Team1_Player2Id",
                table: "559_Matches",
                column: "Team1_Player2Id",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Matches_559_Members_Team2_Player1Id",
                table: "559_Matches",
                column: "Team2_Player1Id",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Matches_559_Members_Team2_Player2Id",
                table: "559_Matches",
                column: "Team2_Player2Id",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Matches_559_Tournaments_TournamentId",
                table: "559_Matches",
                column: "TournamentId",
                principalTable: "559_Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_559_Members_AspNetUsers_UserId",
                table: "559_Members",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_News_559_Members_CreatedByMemberId",
                table: "559_News",
                column: "CreatedByMemberId",
                principalTable: "559_Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_559_Notifications_559_Members_ReceiverId",
                table: "559_Notifications",
                column: "ReceiverId",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_559_TournamentParticipants_559_Members_MemberId",
                table: "559_TournamentParticipants",
                column: "MemberId",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_559_TournamentParticipants_559_Members_PartnerId",
                table: "559_TournamentParticipants",
                column: "PartnerId",
                principalTable: "559_Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_559_TournamentParticipants_559_Tournaments_TournamentId",
                table: "559_TournamentParticipants",
                column: "TournamentId",
                principalTable: "559_Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_559_WalletTransactions_559_Members_MemberId",
                table: "559_WalletTransactions",
                column: "MemberId",
                principalTable: "559_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_559_Bookings_559_Bookings_ParentBookingId",
                table: "559_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Bookings_559_Courts_CourtId",
                table: "559_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Bookings_559_Members_MemberId",
                table: "559_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Bookings_559_WalletTransactions_TransactionId",
                table: "559_Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Matches_559_Courts_CourtId",
                table: "559_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Matches_559_Members_Team1_Player1Id",
                table: "559_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Matches_559_Members_Team1_Player2Id",
                table: "559_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Matches_559_Members_Team2_Player1Id",
                table: "559_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Matches_559_Members_Team2_Player2Id",
                table: "559_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Matches_559_Tournaments_TournamentId",
                table: "559_Matches");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Members_AspNetUsers_UserId",
                table: "559_Members");

            migrationBuilder.DropForeignKey(
                name: "FK_559_News_559_Members_CreatedByMemberId",
                table: "559_News");

            migrationBuilder.DropForeignKey(
                name: "FK_559_Notifications_559_Members_ReceiverId",
                table: "559_Notifications");

            migrationBuilder.DropForeignKey(
                name: "FK_559_TournamentParticipants_559_Members_MemberId",
                table: "559_TournamentParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_559_TournamentParticipants_559_Members_PartnerId",
                table: "559_TournamentParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_559_TournamentParticipants_559_Tournaments_TournamentId",
                table: "559_TournamentParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_559_WalletTransactions_559_Members_MemberId",
                table: "559_WalletTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_WalletTransactions",
                table: "559_WalletTransactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_TransactionCategories",
                table: "559_TransactionCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_Tournaments",
                table: "559_Tournaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_TournamentParticipants",
                table: "559_TournamentParticipants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_Notifications",
                table: "559_Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_News",
                table: "559_News");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_Members",
                table: "559_Members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_Matches",
                table: "559_Matches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_Courts",
                table: "559_Courts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_559_Bookings",
                table: "559_Bookings");

            migrationBuilder.RenameTable(
                name: "559_WalletTransactions",
                newName: "734_WalletTransactions");

            migrationBuilder.RenameTable(
                name: "559_TransactionCategories",
                newName: "734_TransactionCategories");

            migrationBuilder.RenameTable(
                name: "559_Tournaments",
                newName: "734_Tournaments");

            migrationBuilder.RenameTable(
                name: "559_TournamentParticipants",
                newName: "734_TournamentParticipants");

            migrationBuilder.RenameTable(
                name: "559_Notifications",
                newName: "734_Notifications");

            migrationBuilder.RenameTable(
                name: "559_News",
                newName: "734_News");

            migrationBuilder.RenameTable(
                name: "559_Members",
                newName: "734_Members");

            migrationBuilder.RenameTable(
                name: "559_Matches",
                newName: "734_Matches");

            migrationBuilder.RenameTable(
                name: "559_Courts",
                newName: "734_Courts");

            migrationBuilder.RenameTable(
                name: "559_Bookings",
                newName: "734_Bookings");

            migrationBuilder.RenameIndex(
                name: "IX_559_WalletTransactions_MemberId",
                table: "734_WalletTransactions",
                newName: "IX_734_WalletTransactions_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_559_TournamentParticipants_TournamentId",
                table: "734_TournamentParticipants",
                newName: "IX_734_TournamentParticipants_TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_559_TournamentParticipants_PartnerId",
                table: "734_TournamentParticipants",
                newName: "IX_734_TournamentParticipants_PartnerId");

            migrationBuilder.RenameIndex(
                name: "IX_559_TournamentParticipants_MemberId",
                table: "734_TournamentParticipants",
                newName: "IX_734_TournamentParticipants_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Notifications_ReceiverId_IsRead",
                table: "734_Notifications",
                newName: "IX_734_Notifications_ReceiverId_IsRead");

            migrationBuilder.RenameIndex(
                name: "IX_559_News_CreatedByMemberId",
                table: "734_News",
                newName: "IX_734_News_CreatedByMemberId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Members_UserId",
                table: "734_Members",
                newName: "IX_734_Members_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Matches_TournamentId",
                table: "734_Matches",
                newName: "IX_734_Matches_TournamentId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Matches_Team2_Player2Id",
                table: "734_Matches",
                newName: "IX_734_Matches_Team2_Player2Id");

            migrationBuilder.RenameIndex(
                name: "IX_559_Matches_Team2_Player1Id",
                table: "734_Matches",
                newName: "IX_734_Matches_Team2_Player1Id");

            migrationBuilder.RenameIndex(
                name: "IX_559_Matches_Team1_Player2Id",
                table: "734_Matches",
                newName: "IX_734_Matches_Team1_Player2Id");

            migrationBuilder.RenameIndex(
                name: "IX_559_Matches_Team1_Player1Id",
                table: "734_Matches",
                newName: "IX_734_Matches_Team1_Player1Id");

            migrationBuilder.RenameIndex(
                name: "IX_559_Matches_CourtId",
                table: "734_Matches",
                newName: "IX_734_Matches_CourtId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Bookings_TransactionId",
                table: "734_Bookings",
                newName: "IX_734_Bookings_TransactionId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Bookings_ParentBookingId",
                table: "734_Bookings",
                newName: "IX_734_Bookings_ParentBookingId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Bookings_MemberId",
                table: "734_Bookings",
                newName: "IX_734_Bookings_MemberId");

            migrationBuilder.RenameIndex(
                name: "IX_559_Bookings_CourtId_StartTime_EndTime",
                table: "734_Bookings",
                newName: "IX_734_Bookings_CourtId_StartTime_EndTime");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_WalletTransactions",
                table: "734_WalletTransactions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_TransactionCategories",
                table: "734_TransactionCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_Tournaments",
                table: "734_Tournaments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_TournamentParticipants",
                table: "734_TournamentParticipants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_Notifications",
                table: "734_Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_News",
                table: "734_News",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_Members",
                table: "734_Members",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_Matches",
                table: "734_Matches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_Courts",
                table: "734_Courts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_734_Bookings",
                table: "734_Bookings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_734_Bookings_734_Bookings_ParentBookingId",
                table: "734_Bookings",
                column: "ParentBookingId",
                principalTable: "734_Bookings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Bookings_734_Courts_CourtId",
                table: "734_Bookings",
                column: "CourtId",
                principalTable: "734_Courts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Bookings_734_Members_MemberId",
                table: "734_Bookings",
                column: "MemberId",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Bookings_734_WalletTransactions_TransactionId",
                table: "734_Bookings",
                column: "TransactionId",
                principalTable: "734_WalletTransactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_734_Matches_734_Courts_CourtId",
                table: "734_Matches",
                column: "CourtId",
                principalTable: "734_Courts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_734_Matches_734_Members_Team1_Player1Id",
                table: "734_Matches",
                column: "Team1_Player1Id",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Matches_734_Members_Team1_Player2Id",
                table: "734_Matches",
                column: "Team1_Player2Id",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Matches_734_Members_Team2_Player1Id",
                table: "734_Matches",
                column: "Team2_Player1Id",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Matches_734_Members_Team2_Player2Id",
                table: "734_Matches",
                column: "Team2_Player2Id",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Matches_734_Tournaments_TournamentId",
                table: "734_Matches",
                column: "TournamentId",
                principalTable: "734_Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_734_Members_AspNetUsers_UserId",
                table: "734_Members",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_News_734_Members_CreatedByMemberId",
                table: "734_News",
                column: "CreatedByMemberId",
                principalTable: "734_Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_734_Notifications_734_Members_ReceiverId",
                table: "734_Notifications",
                column: "ReceiverId",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_734_TournamentParticipants_734_Members_MemberId",
                table: "734_TournamentParticipants",
                column: "MemberId",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_734_TournamentParticipants_734_Members_PartnerId",
                table: "734_TournamentParticipants",
                column: "PartnerId",
                principalTable: "734_Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_734_TournamentParticipants_734_Tournaments_TournamentId",
                table: "734_TournamentParticipants",
                column: "TournamentId",
                principalTable: "734_Tournaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_734_WalletTransactions_734_Members_MemberId",
                table: "734_WalletTransactions",
                column: "MemberId",
                principalTable: "734_Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
