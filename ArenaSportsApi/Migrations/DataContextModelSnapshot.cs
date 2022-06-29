﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArenaSportsApi.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArenaSportsApi.Models.Churrasqueira", b =>
                {
                    b.Property<int>("ChurrasqueiraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoItens")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UsuarioExclusaoId")
                        .HasColumnType("bigint");

                    b.HasKey("ChurrasqueiraId");

                    b.HasIndex("UsuarioExclusaoId");

                    b.ToTable("Churrasqueira");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ChurrasqueiraPacote", b =>
                {
                    b.Property<int>("ChurrasqueiraPacoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UsuarioExclusaoId")
                        .HasColumnType("bigint");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ChurrasqueiraPacoteId");

                    b.HasIndex("UsuarioExclusaoId");

                    b.ToTable("ChurrasqueiraPacote");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.Quadra", b =>
                {
                    b.Property<int>("QuadraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<bool>("Coberta")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EsporteId")
                        .HasColumnType("int");

                    b.Property<int>("PisoId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<long?>("UsuarioExclusaoId")
                        .HasColumnType("bigint");

                    b.HasKey("QuadraId");

                    b.HasIndex("UsuarioExclusaoId");

                    b.ToTable("Quadra");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.QuadraConfiguracaoHorario", b =>
                {
                    b.Property<int>("QuadraConfiguracaoHorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DiaSemana")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Duracao")
                        .HasColumnType("time");

                    b.Property<int>("QuadraId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("TimeFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TimeInicio")
                        .HasColumnType("time");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("QuadraConfiguracaoHorarioId");

                    b.HasIndex("QuadraId");

                    b.ToTable("QuadraConfiguracaoHorario");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.QuadraItemOpcional", b =>
                {
                    b.Property<int>("QuadraItemOpcionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DataExclusao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UsuarioExclusaoId")
                        .HasColumnType("bigint");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("QuadraItemOpcionalId");

                    b.HasIndex("UsuarioExclusaoId");

                    b.ToTable("QuadraItemOpcional");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.Reserva", b =>
                {
                    b.Property<long>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CancelamentoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DataCancelamento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataRequisicao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataReserva")
                        .HasColumnType("datetime2");

                    b.Property<long>("RequisicaoUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<long>("ReservaUsuarioId")
                        .HasColumnType("bigint");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<float>("ValorTotal")
                        .HasColumnType("real");

                    b.HasKey("ReservaId");

                    b.HasIndex("CancelamentoUsuarioId");

                    b.HasIndex("RequisicaoUsuarioId");

                    b.HasIndex("ReservaUsuarioId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ReservaChurrasqueira", b =>
                {
                    b.Property<long>("ReservaChurrasqueiraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChurrasqueiraId")
                        .HasColumnType("int");

                    b.Property<int>("ChurrasqueiraPacoteId")
                        .HasColumnType("int");

                    b.Property<long>("ReservaId")
                        .HasColumnType("bigint");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ReservaChurrasqueiraId");

                    b.HasIndex("ChurrasqueiraId");

                    b.HasIndex("ChurrasqueiraPacoteId");

                    b.HasIndex("ReservaId");

                    b.ToTable("ReservaChurrasqueira");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ReservaQuadra", b =>
                {
                    b.Property<long>("ReservaQuadraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuadraId")
                        .HasColumnType("int");

                    b.Property<long>("ReservaId")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("TimeFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("TimeInicio")
                        .HasColumnType("time");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ReservaQuadraId");

                    b.HasIndex("QuadraId");

                    b.HasIndex("ReservaId");

                    b.ToTable("ReservaQuadra");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ReservaQuadraOpcional", b =>
                {
                    b.Property<long>("ReservaQuadraOpcionalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuadraItemOpcionalId")
                        .HasColumnType("int");

                    b.Property<long>("ReservaQuadraId")
                        .HasColumnType("bigint");

                    b.Property<float>("Valor")
                        .HasColumnType("real");

                    b.HasKey("ReservaQuadraOpcionalId");

                    b.HasIndex("QuadraItemOpcionalId");

                    b.HasIndex("ReservaQuadraId");

                    b.ToTable("ReservaQuadraOpcional");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.Usuario", b =>
                {
                    b.Property<long>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("TipoUsuarioId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.UsuarioEmailConfirmacao", b =>
                {
                    b.Property<long>("UsuarioEmailConfirmacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DataConfirmacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSolicitacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmado")
                        .HasColumnType("bit");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("bigint");

                    b.HasKey("UsuarioEmailConfirmacaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioEmailConfirmacao");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.Churrasqueira", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Usuario", "UsuarioExclusao")
                        .WithMany()
                        .HasForeignKey("UsuarioExclusaoId");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ChurrasqueiraPacote", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Usuario", "UsuarioExclusao")
                        .WithMany()
                        .HasForeignKey("UsuarioExclusaoId");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.Quadra", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioExclusaoId");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.QuadraConfiguracaoHorario", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Quadra", "Quadra")
                        .WithMany("ConfigsHorarioQuadra")
                        .HasForeignKey("QuadraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArenaSportsApi.Models.QuadraItemOpcional", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Usuario", "UsuarioExclusao")
                        .WithMany()
                        .HasForeignKey("UsuarioExclusaoId");
                });

            modelBuilder.Entity("ArenaSportsApi.Models.Reserva", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Usuario", "UsuarioCancelamento")
                        .WithMany()
                        .HasForeignKey("CancelamentoUsuarioId");

                    b.HasOne("ArenaSportsApi.Models.Usuario", "UsuarioRequisicao")
                        .WithMany()
                        .HasForeignKey("RequisicaoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaSportsApi.Models.Usuario", "Cliente")
                        .WithMany()
                        .HasForeignKey("ReservaUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ReservaChurrasqueira", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Churrasqueira", "Churrasqueira")
                        .WithMany()
                        .HasForeignKey("ChurrasqueiraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaSportsApi.Models.ChurrasqueiraPacote", "Pacote")
                        .WithMany()
                        .HasForeignKey("ChurrasqueiraPacoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaSportsApi.Models.Reserva", "Reserva")
                        .WithMany("Churrasqueiras")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ReservaQuadra", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Quadra", "Quadra")
                        .WithMany()
                        .HasForeignKey("QuadraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaSportsApi.Models.Reserva", "Reserva")
                        .WithMany("Quadras")
                        .HasForeignKey("ReservaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArenaSportsApi.Models.ReservaQuadraOpcional", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.QuadraItemOpcional", "QuadraItemOpcional")
                        .WithMany()
                        .HasForeignKey("QuadraItemOpcionalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArenaSportsApi.Models.ReservaQuadra", "ReservaQuadra")
                        .WithMany("Opcionais")
                        .HasForeignKey("ReservaQuadraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArenaSportsApi.Models.UsuarioEmailConfirmacao", b =>
                {
                    b.HasOne("ArenaSportsApi.Models.Usuario", "Usuario")
                        .WithMany("UsuarioConfirmacoesEmail")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
