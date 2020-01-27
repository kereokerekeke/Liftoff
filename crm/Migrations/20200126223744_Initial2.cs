using Microsoft.EntityFrameworkCore.Migrations;

namespace crm.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_Allergies_AllergyId",
                table: "PatientAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_Patients_PatientId",
                table: "PatientAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Appointments_AppointmentId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Appointments_AppointmentId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Tests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PatrientId",
                table: "Tests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Prescriptions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_PatientId",
                table: "Tests",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientID",
                table: "Appointments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_Allergies_AllergyId",
                table: "PatientAllergies",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_Patients_PatientId",
                table: "PatientAllergies",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Appointments_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Appointments_AppointmentId",
                table: "Tests",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Patients_PatientId",
                table: "Tests",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Patients_PatientID",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_Allergies_AllergyId",
                table: "PatientAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_PatientAllergies_Patients_PatientId",
                table: "PatientAllergies");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Appointments_AppointmentId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Appointments_AppointmentId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Patients_PatientId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_PatientId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "PatrientId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Prescriptions");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Patients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DoctorId",
                table: "Patients",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorID",
                table: "Appointments",
                column: "DoctorID",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Patients_PatientID",
                table: "Appointments",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_Allergies_AllergyId",
                table: "PatientAllergies",
                column: "AllergyId",
                principalTable: "Allergies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PatientAllergies_Patients_PatientId",
                table: "PatientAllergies",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Doctors_DoctorId",
                table: "Patients",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Appointments_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Appointments_AppointmentId",
                table: "Tests",
                column: "AppointmentId",
                principalTable: "Appointments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
