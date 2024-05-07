using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetConsultas.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadPacienteModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTutor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CpfTutor = table.Column<int>(type: "int", nullable: false),
                    login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senhaTutor = table.Column<int>(type: "int", nullable: false),
                    usuarios = table.Column<int>(type: "int", nullable: false),
                    datacadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataarualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadPacienteModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadProfissionalModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    especialidadeProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emailProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpfProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    crmvlProfissional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    datacadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dataarualizacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadProfissionalModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomePaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especialidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataConsulta = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadPacienteModel");

            migrationBuilder.DropTable(
                name: "CadProfissionalModel");

            migrationBuilder.DropTable(
                name: "Consultas");
        }
    }
}
