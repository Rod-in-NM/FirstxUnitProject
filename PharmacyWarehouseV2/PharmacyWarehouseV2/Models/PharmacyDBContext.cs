using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PharmacyWarehouseV2.Models
{
    public partial class PharmacyDBContext : DbContext
    {
        public PharmacyDBContext()
        {
        }

        public PharmacyDBContext(DbContextOptions<PharmacyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<APharmInvInItemPackage> APharmInvInItemPackages { get; set; } = null!;
        public virtual DbSet<APharmInvOutItemPackage> APharmInvOutItemPackages { get; set; } = null!;
        public virtual DbSet<APharmInvOutItemPackageReceipt> APharmInvOutItemPackageReceipts { get; set; } = null!;
        public virtual DbSet<APharmInventoryIn> APharmInventoryIns { get; set; } = null!;
        public virtual DbSet<APharmInventoryOut> APharmInventoryOuts { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<IntTally> IntTallies { get; set; } = null!;
        public virtual DbSet<InterofficeTransfer> InterofficeTransfers { get; set; } = null!;
        public virtual DbSet<InterofficeTransferItem> InterofficeTransferItems { get; set; } = null!;
        public virtual DbSet<OrphanedPharmInvOutItemPackage> OrphanedPharmInvOutItemPackages { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<PharmBackorder> PharmBackorders { get; set; } = null!;
        public virtual DbSet<PharmClinicLicenseClass> PharmClinicLicenseClasses { get; set; } = null!;
        public virtual DbSet<PharmClinician> PharmClinicians { get; set; } = null!;
        public virtual DbSet<PharmClinicianCertification> PharmClinicianCertifications { get; set; } = null!;
        public virtual DbSet<PharmClinicianCertificationsOld> PharmClinicianCertificationsOlds { get; set; } = null!;
        public virtual DbSet<PharmContainerType> PharmContainerTypes { get; set; } = null!;
        public virtual DbSet<PharmDrugDosageForm> PharmDrugDosageForms { get; set; } = null!;
        public virtual DbSet<PharmEmployee> PharmEmployees { get; set; } = null!;
        public virtual DbSet<PharmInvInItemPackage> PharmInvInItemPackages { get; set; } = null!;
        public virtual DbSet<PharmInvOutItemPackage> PharmInvOutItemPackages { get; set; } = null!;
        public virtual DbSet<PharmInvOutItemPackageReceipt> PharmInvOutItemPackageReceipts { get; set; } = null!;
        public virtual DbSet<PharmInventoryAction> PharmInventoryActions { get; set; } = null!;
        public virtual DbSet<PharmInventoryIn> PharmInventoryIns { get; set; } = null!;
        public virtual DbSet<PharmInventoryOut> PharmInventoryOuts { get; set; } = null!;
        public virtual DbSet<PharmInventoryOutNoteChoice> PharmInventoryOutNoteChoices { get; set; } = null!;
        public virtual DbSet<PharmItemClass> PharmItemClasses { get; set; } = null!;
        public virtual DbSet<PharmItemNdcnum> PharmItemNdcnums { get; set; } = null!;
        public virtual DbSet<PharmItemNdcnumsOld> PharmItemNdcnumsOlds { get; set; } = null!;
        public virtual DbSet<PharmItemPackage> PharmItemPackages { get; set; } = null!;
        public virtual DbSet<PharmItemPackageProgram> PharmItemPackagePrograms { get; set; } = null!;
        public virtual DbSet<PharmItemReturnType> PharmItemReturnTypes { get; set; } = null!;
        public virtual DbSet<PharmItemsOriginal> PharmItemsOriginals { get; set; } = null!;
        public virtual DbSet<PharmItemsReturnedExpiredFromLoc> PharmItemsReturnedExpiredFromLocs { get; set; } = null!;
        public virtual DbSet<PharmLocation> PharmLocations { get; set; } = null!;
        public virtual DbSet<PharmLocation340BRegistration> PharmLocation340BRegistrations { get; set; } = null!;
        public virtual DbSet<PharmLocationPaprogContract> PharmLocationPaprogContracts { get; set; } = null!;
        public virtual DbSet<PharmLocationType> PharmLocationTypes { get; set; } = null!;
        public virtual DbSet<PharmManufacturer> PharmManufacturers { get; set; } = null!;
        public virtual DbSet<PharmOrderedByPerson> PharmOrderedByPersons { get; set; } = null!;
        public virtual DbSet<PharmPaprogContract> PharmPaprogContracts { get; set; } = null!;
        public virtual DbSet<PharmPreference> PharmPreferences { get; set; } = null!;
        public virtual DbSet<PharmPrescriptionType> PharmPrescriptionTypes { get; set; } = null!;
        public virtual DbSet<PharmShelfLocation> PharmShelfLocations { get; set; } = null!;
        public virtual DbSet<PharmShipper> PharmShippers { get; set; } = null!;
        public virtual DbSet<PharmSupplierVendor> PharmSupplierVendors { get; set; } = null!;
        public virtual DbSet<PharmYear> PharmYears { get; set; } = null!;
        public virtual DbSet<Program> Programs { get; set; } = null!;
        public virtual DbSet<VwAllInventoryInByItemPackageId> VwAllInventoryInByItemPackageIds { get; set; } = null!;
        public virtual DbSet<VwAllInventoryOutByItemPackageId> VwAllInventoryOutByItemPackageIds { get; set; } = null!;
        public virtual DbSet<VwInvInMinItemPackageId> VwInvInMinItemPackageIds { get; set; } = null!;
        public virtual DbSet<VwInvOutItemPackageReceiptsIssued> VwInvOutItemPackageReceiptsIssueds { get; set; } = null!;
        public virtual DbSet<VwItemPackageIds340B> VwItemPackageIds340Bs { get; set; } = null!;
        public virtual DbSet<VwItemQtysOnHandAllItemsSqlview> VwItemQtysOnHandAllItemsSqlviews { get; set; } = null!;
        public virtual DbSet<VwItemsIssuedSumAllItem> VwItemsIssuedSumAllItems { get; set; } = null!;
        public virtual DbSet<VwItemsRcvdSumAllItem> VwItemsRcvdSumAllItems { get; set; } = null!;
        public virtual DbSet<VwNewPharmItem> VwNewPharmItems { get; set; } = null!;
        public virtual DbSet<VwPharmInvOutItemPackageReceiptsAll> VwPharmInvOutItemPackageReceiptsAlls { get; set; } = null!;
        public virtual DbSet<VwPharmItem> VwPharmItems { get; set; } = null!;
        public virtual DbSet<ZzTempForInvOutItemPackagesBackordered> ZzTempForInvOutItemPackagesBackordereds { get; set; } = null!;
        public virtual DbSet<ZzTempItemsBo> ZzTempItemsBos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DOHREG2SIMM169;Initial Catalog=PharmacyDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APharmInvInItemPackage>(entity =>
            {
                entity.HasKey(e => e.InventoryInDetailId)
                    .HasName("A_PharmInvInItemPackages_PK")
                    .IsClustered(false);

                entity.ToTable("A_PharmInvInItemPackages");

                entity.Property(e => e.InventoryInDetailId)
                    .ValueGeneratedNever()
                    .HasColumnName("InventoryInDetailID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp).HasMaxLength(8);

                entity.Property(e => e.InventoryInId).HasColumnName("InventoryInID");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.ItemDescr).HasMaxLength(60);

                entity.Property(e => e.ItemNdcnum)
                    .HasMaxLength(20)
                    .HasColumnName("ItemNDCNum");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.LotExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LotExpiredYn).HasColumnName("LotExpiredYN");

                entity.Property(e => e.LotNum).HasMaxLength(20);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.ShelfLocationId).HasColumnName("ShelfLocationID");

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.HasOne(d => d.InventoryIn)
                    .WithMany(p => p.APharmInvInItemPackages)
                    .HasForeignKey(d => d.InventoryInId)
                    .HasConstraintName("FK_A_PharmInvInItemPackages_A_PharmInventoryIn");
            });

            modelBuilder.Entity<APharmInvOutItemPackage>(entity =>
            {
                entity.HasKey(e => e.InvOutItemLineId)
                    .HasName("A_PharmInvOutItemPackages_PK");

                entity.ToTable("A_PharmInvOutItemPackages");

                entity.Property(e => e.InvOutItemLineId)
                    .ValueGeneratedNever()
                    .HasColumnName("InvOutItemLineID");

                entity.Property(e => e.BackorderedYn).HasColumnName("BackorderedYN");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp).HasMaxLength(8);

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.TotalCostThisItem).HasColumnType("money");

                entity.HasOne(d => d.InventoryOut)
                    .WithMany(p => p.APharmInvOutItemPackages)
                    .HasForeignKey(d => d.InventoryOutId)
                    .HasConstraintName("FK_A_PharmInvOutItemPackages_A_PharmInventoryOut");
            });

            modelBuilder.Entity<APharmInvOutItemPackageReceipt>(entity =>
            {
                entity.HasKey(e => e.InvOutItemPackageReceiptId)
                    .HasName("A_PharmInvOutItemPackageReceipts_PK");

                entity.ToTable("A_PharmInvOutItemPackageReceipts");

                entity.Property(e => e.InvOutItemPackageReceiptId)
                    .ValueGeneratedNever()
                    .HasColumnName("InvOutItemPackageReceiptID");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp).HasMaxLength(8);

                entity.Property(e => e.InvOutItemLineId).HasColumnName("InvOutItemLineID");

                entity.Property(e => e.InventoryInDetailId).HasColumnName("InventoryInDetailID");

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.IsReceiptItem340BYn).HasColumnName("IsReceiptItem340B_YN");

                entity.Property(e => e.ItemCost).HasColumnType("money");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.TotalCostThisReceipt).HasColumnType("money");

                entity.HasOne(d => d.InvOutItemLine)
                    .WithMany(p => p.APharmInvOutItemPackageReceipts)
                    .HasForeignKey(d => d.InvOutItemLineId)
                    .HasConstraintName("FK_A_PharmInvOutItemPackageReceipts_A_PharmInvOutItemPackages");

                entity.HasOne(d => d.InventoryInDetail)
                    .WithMany(p => p.APharmInvOutItemPackageReceipts)
                    .HasForeignKey(d => d.InventoryInDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_PharmInvOutItemPackageReceipts_A_PharmInvInItemPackages");
            });

            modelBuilder.Entity<APharmInventoryIn>(entity =>
            {
                entity.HasKey(e => e.InventoryInId)
                    .HasName("A_PharmInventoryIn_PK")
                    .IsClustered(false);

                entity.ToTable("A_PharmInventoryIn");

                entity.Property(e => e.InventoryInId)
                    .ValueGeneratedNever()
                    .HasColumnName("InventoryInID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.InventoryActionId).HasColumnName("InventoryActionID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.OrderedByEmployeeId).HasColumnName("OrderedByEmployeeID");

                entity.Property(e => e.PostedYn).HasColumnName("PostedYN");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ReasonReturned).HasMaxLength(50);

                entity.Property(e => e.ReceivedByEmployeeId).HasColumnName("ReceivedByEmployeeID");

                entity.Property(e => e.ReturnedFromLocationId).HasColumnName("ReturnedFromLocationID");

                entity.Property(e => e.ShipmentInPonum)
                    .HasMaxLength(20)
                    .HasColumnName("ShipmentInPONum");

                entity.Property(e => e.StateFiscalYearAbbrev).HasMaxLength(10);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierInvoiceNum).HasMaxLength(20);

                entity.Property(e => e.SupplierOrderNum).HasMaxLength(20);
            });

            modelBuilder.Entity<APharmInventoryOut>(entity =>
            {
                entity.HasKey(e => e.InventoryOutId)
                    .HasName("A_PharmInventoryOut_PK")
                    .IsClustered(false);

                entity.ToTable("A_PharmInventoryOut");

                entity.Property(e => e.InventoryOutId)
                    .ValueGeneratedNever()
                    .HasColumnName("InventoryOutID");

                entity.Property(e => e.CheckedByEmployeeId).HasColumnName("CheckedByEmployeeID");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.ClinicianName).HasMaxLength(50);

                entity.Property(e => e.DateChecked).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateFilled).HasColumnType("datetime");

                entity.Property(e => e.DateIssuedShipped).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateOrdered).HasColumnType("datetime");

                entity.Property(e => e.FilledByEmployeeId).HasColumnName("FilledByEmployeeID");

                entity.Property(e => e.InventoryActionId).HasColumnName("InventoryActionID");

                entity.Property(e => e.IssueShippedAndLockedYn).HasColumnName("IssueShippedAndLockedYN");

                entity.Property(e => e.IssuedShippedByEmployeeId).HasColumnName("IssuedShippedByEmployeeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.OrderedById).HasColumnName("OrderedByID");

                entity.Property(e => e.OrderedByName).HasMaxLength(50);

                entity.Property(e => e.PostedYn).HasColumnName("PostedYN");

                entity.Property(e => e.ShipCarrierId).HasColumnName("ShipCarrierID");

                entity.Property(e => e.StateFiscalYearAbbrev).HasMaxLength(10);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasComment("Also called Program");

                entity.Property(e => e.ActiveYn).HasColumnName("ActiveYN");

                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DepartmentAbbrev).HasMaxLength(10);

                entity.Property(e => e.DohdepartmentDescr)
                    .HasMaxLength(50)
                    .HasColumnName("DOHDepartmentDescr");

                entity.Property(e => e.DohdepartmentId)
                    .HasMaxLength(20)
                    .HasColumnName("DOHDepartmentID");

                entity.Property(e => e.EnteredBy).HasMaxLength(50);

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");
            });

            modelBuilder.Entity<IntTally>(entity =>
            {
                entity.HasKey(e => e.TallyId);

                entity.ToTable("IntTally");

                entity.Property(e => e.TallyId)
                    .ValueGeneratedNever()
                    .HasColumnName("TallyID");
            });

            modelBuilder.Entity<InterofficeTransfer>(entity =>
            {
                entity.HasKey(e => e.TransferId);

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.FromNurse).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.ToNurse).HasMaxLength(50);

                entity.Property(e => e.TransferDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TransferNumber).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InterofficeTransferItem>(entity =>
            {
                entity.HasKey(e => e.TransferItemId);

                entity.Property(e => e.TransferItemId).HasColumnName("TransferItemID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LotExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LotNum).HasMaxLength(20);

                entity.Property(e => e.TransferId).HasColumnName("TransferID");
            });

            modelBuilder.Entity<OrphanedPharmInvOutItemPackage>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BackorderedYn).HasColumnName("BackorderedYN");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.InvOutItemLineId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("InvOutItemLineID");

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.TotalCostThisItem).HasColumnType("money");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId)
                    .ValueGeneratedNever()
                    .HasColumnName("PersonID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);
            });

            modelBuilder.Entity<PharmBackorder>(entity =>
            {
                entity.HasKey(e => e.BackorderId);

                entity.Property(e => e.BackorderId).HasColumnName("BackorderID");

                entity.Property(e => e.BackorderInventoryOutId).HasColumnName("BackorderInventoryOutID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.OrigInventoryOutId).HasColumnName("OrigInventoryOutID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            });

            modelBuilder.Entity<PharmClinicLicenseClass>(entity =>
            {
                entity.HasKey(e => e.ClinicLicenseClassId);

                entity.Property(e => e.ClinicLicenseClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("ClinicLicenseClassID");

                entity.Property(e => e.ClinicLicenseClass).HasMaxLength(10);

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy).HasMaxLength(50);

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");
            });

            modelBuilder.Entity<PharmClinician>(entity =>
            {
                entity.HasKey(e => e.ClinicianId);

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.ActiveYn)
                    .HasColumnName("ActiveYN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ClinicianName).HasMaxLength(50);

                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ImplanonCertified).HasDefaultValueSql("((0))");

                entity.Property(e => e.NexplanonCertEndDate).HasColumnType("datetime");

                entity.Property(e => e.NexplanonCertified).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PharmClinicianCertification>(entity =>
            {
                entity.HasKey(e => e.PharmClinicianCertificationsId)
                    .IsClustered(false);

                entity.Property(e => e.PharmClinicianCertificationsId).HasColumnName("PharmClinicianCertificationsID");

                entity.Property(e => e.ActiveYn).HasColumnName("ActiveYN");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ItemOriginalId).HasColumnName("ItemOriginalID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.HasOne(d => d.Clinician)
                    .WithMany(p => p.PharmClinicianCertifications)
                    .HasForeignKey(d => d.ClinicianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PharmClinicianCertifications_PharmClinicians_FK");

                entity.HasOne(d => d.ItemOriginal)
                    .WithMany(p => p.PharmClinicianCertifications)
                    .HasForeignKey(d => d.ItemOriginalId)
                    .HasConstraintName("PharmClinicianCertifications_PharmItemsOriginal_FK");

                entity.HasOne(d => d.ItemPackage)
                    .WithMany(p => p.PharmClinicianCertifications)
                    .HasForeignKey(d => d.ItemPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PharmClinicianCertifications_PharmItemPackages_FK");
            });

            modelBuilder.Entity<PharmClinicianCertificationsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PharmClinicianCertificationsOLD");

                entity.Property(e => e.ActiveYn).HasColumnName("ActiveYN");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ItemOriginalId).HasColumnName("ItemOriginalID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.HasOne(d => d.Clinician)
                    .WithMany()
                    .HasForeignKey(d => d.ClinicianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmClinicianCertificationsOLD_PharmClinicians");

                entity.HasOne(d => d.ItemOriginal)
                    .WithMany()
                    .HasForeignKey(d => d.ItemOriginalId)
                    .HasConstraintName("FK_PharmClinicianCertificationsOLD_PharmItemsOriginal");

                entity.HasOne(d => d.ItemPackage)
                    .WithMany()
                    .HasForeignKey(d => d.ItemPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmClinicianCertificationsOLD_PharmItemPackages");
            });

            modelBuilder.Entity<PharmContainerType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContainerType)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ContainerTypeId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ContainerTypeID");
            });

            modelBuilder.Entity<PharmDrugDosageForm>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DrugDosageForm)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DrugDosageFormId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DrugDosageFormID");
            });

            modelBuilder.Entity<PharmEmployee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.HasIndex(e => e.EmployeeId, "EmployeeID")
                    .IsUnique()
                    .HasFillFactor(100);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.ActiveYn)
                    .IsRequired()
                    .HasColumnName("ActiveYN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EmployeeFirstName).HasMaxLength(50);

                entity.Property(e => e.EmployeeLastName).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(30);

                entity.Property(e => e.PhoneHome).HasMaxLength(20);
            });

            modelBuilder.Entity<PharmInvInItemPackage>(entity =>
            {
                entity.HasKey(e => e.InventoryInDetailId)
                    .HasName("aaaaaPharmInventoryInItems_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.InventoryInDetailId, "DetailID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ItemPackageId, "ItemID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ItemNdcnum, "ItemNDCNum")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.LotNum, "Lot#")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.InventoryInId, "OrderID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.InventoryInId, "{463C2F7A-3926-412C-9677-F6C0B08C84FE}")
                    .HasFillFactor(100);

                entity.Property(e => e.InventoryInDetailId).HasColumnName("InventoryInDetailID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.InventoryInId).HasColumnName("InventoryInID");

                entity.Property(e => e.Is340BYn)
                    .HasColumnName("Is340B_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemCost).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemDescr).HasMaxLength(60);

                entity.Property(e => e.ItemNdcnum)
                    .HasMaxLength(20)
                    .HasColumnName("ItemNDCNum");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn)
                    .HasColumnName("LabelledYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LotExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LotExpiredYn).HasColumnName("LotExpiredYN");

                entity.Property(e => e.LotNum).HasMaxLength(20);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.QtyPerPackage).HasDefaultValueSql("((1))");

                entity.Property(e => e.QtyReceived).HasDefaultValueSql("((0))");

                entity.Property(e => e.QtyRequestedForIssue).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShelfLocationId).HasColumnName("ShelfLocationID");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.InventoryIn)
                    .WithMany(p => p.PharmInvInItemPackages)
                    .HasForeignKey(d => d.InventoryInId)
                    .HasConstraintName("FK_PharmInvInItemPackages_PharmInventoryIn");

                entity.HasOne(d => d.ItemPackage)
                    .WithMany(p => p.PharmInvInItemPackages)
                    .HasForeignKey(d => d.ItemPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmInvInItemPackages_PharmItemPackages");
            });

            modelBuilder.Entity<PharmInvOutItemPackage>(entity =>
            {
                entity.HasKey(e => e.InvOutItemLineId)
                    .HasName("PK_PharmInvOutItems");

                entity.Property(e => e.InvOutItemLineId).HasColumnName("InvOutItemLineID");

                entity.Property(e => e.BackorderedYn).HasColumnName("BackorderedYN");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.TotalCostThisItem).HasColumnType("money");

                entity.HasOne(d => d.InventoryOut)
                    .WithMany(p => p.PharmInvOutItemPackages)
                    .HasForeignKey(d => d.InventoryOutId)
                    .HasConstraintName("FK_PharmInvOutItemPackages_PharmInventoryOut");

                entity.HasOne(d => d.ItemPackage)
                    .WithMany(p => p.PharmInvOutItemPackages)
                    .HasForeignKey(d => d.ItemPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmInvOutItemPackages_PharmItemPackages");
            });

            modelBuilder.Entity<PharmInvOutItemPackageReceipt>(entity =>
            {
                entity.HasKey(e => e.InvOutItemPackageReceiptId);

                entity.Property(e => e.InvOutItemPackageReceiptId).HasColumnName("InvOutItemPackageReceiptID");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.InvOutItemLineId).HasColumnName("InvOutItemLineID");

                entity.Property(e => e.InventoryInDetailId).HasColumnName("InventoryInDetailID");

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.IsReceiptItem340BYn).HasColumnName("IsReceiptItem340B_YN");

                entity.Property(e => e.ItemCost).HasColumnType("money");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.TotalCostThisReceipt).HasColumnType("money");

                entity.HasOne(d => d.InvOutItemLine)
                    .WithMany(p => p.PharmInvOutItemPackageReceipts)
                    .HasForeignKey(d => d.InvOutItemLineId)
                    .HasConstraintName("FK_PharmInvOutItemPackageReceipts_PharmInvOutItemPackages");

                entity.HasOne(d => d.InventoryInDetail)
                    .WithMany(p => p.PharmInvOutItemPackageReceipts)
                    .HasForeignKey(d => d.InventoryInDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmInvOutItemPackageReceipts_PharmInvInItemPackages");
            });

            modelBuilder.Entity<PharmInventoryAction>(entity =>
            {
                entity.HasKey(e => e.InventoryActionId)
                    .HasName("aaaaaPharmInventoryActions_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.InventoryActionId, "OrderTypeID")
                    .HasFillFactor(100);

                entity.Property(e => e.InventoryActionId)
                    .ValueGeneratedNever()
                    .HasColumnName("InventoryActionID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.InventoryAction).HasMaxLength(50);

                entity.Property(e => e.WhereFromOrTo).HasMaxLength(50);
            });

            modelBuilder.Entity<PharmInventoryIn>(entity =>
            {
                entity.HasKey(e => e.InventoryInId)
                    .HasName("aaaaaPharmInventoryIn_PK")
                    .IsClustered(false);

                entity.ToTable("PharmInventoryIn");

                entity.HasIndex(e => e.InventoryActionId, "InventoryActionID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ReturnedFromLocationId, "LocationID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ShipmentInPonum, "Order#")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.InventoryInId, "OrderID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.OrderedByEmployeeId, "OrderedByEmployeeID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ReceivedByEmployeeId, "ReceivedByEmployeeID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.SupplierId, "SupplierID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.StateFiscalYearAbbrev, "YearID")
                    .HasFillFactor(100);

                entity.Property(e => e.InventoryInId).HasColumnName("InventoryInID");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateReceived)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.InventoryActionId).HasColumnName("InventoryActionID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.OrderedByEmployeeId).HasColumnName("OrderedByEmployeeID");

                entity.Property(e => e.PostedYn).HasColumnName("PostedYN");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ReasonReturned).HasMaxLength(50);

                entity.Property(e => e.ReceivedByEmployeeId).HasColumnName("ReceivedByEmployeeID");

                entity.Property(e => e.ReturnedFromLocationId).HasColumnName("ReturnedFromLocationID");

                entity.Property(e => e.ShipmentInPonum)
                    .HasMaxLength(20)
                    .HasColumnName("ShipmentInPONum");

                entity.Property(e => e.StateFiscalYearAbbrev).HasMaxLength(10);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierInvoiceNum).HasMaxLength(20);

                entity.Property(e => e.SupplierOrderNum).HasMaxLength(20);

                entity.HasOne(d => d.InventoryAction)
                    .WithMany(p => p.PharmInventoryIns)
                    .HasForeignKey(d => d.InventoryActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmInventoryIn_PharmInventoryActions");
            });

            modelBuilder.Entity<PharmInventoryOut>(entity =>
            {
                entity.HasKey(e => e.InventoryOutId)
                    .HasName("aaaaaPharmInventoryOut_PK")
                    .IsClustered(false);

                entity.ToTable("PharmInventoryOut");

                entity.HasIndex(e => e.FilledByEmployeeId, "FilledByEmployeeID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.InventoryActionId, "InventoryActionID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.IssuedShippedByEmployeeId, "IssuedShippedByEmployeeID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.LocationId, "LocationID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.InventoryOutId, "OrderID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ShipCarrierId, "ShipCarrierID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.StateFiscalYearAbbrev, "YearID")
                    .HasFillFactor(100);

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.CheckedByEmployeeId).HasColumnName("CheckedByEmployeeID");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.ClinicianName).HasMaxLength(50);

                entity.Property(e => e.DateChecked).HasColumnType("datetime");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateFilled)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateIssuedShipped)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateOrdered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.FilledByEmployeeId).HasColumnName("FilledByEmployeeID");

                entity.Property(e => e.InventoryActionId).HasColumnName("InventoryActionID");

                entity.Property(e => e.IssueShippedAndLockedYn).HasColumnName("IssueShippedAndLockedYN");

                entity.Property(e => e.IssuedShippedByEmployeeId).HasColumnName("IssuedShippedByEmployeeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasColumnType("ntext");

                entity.Property(e => e.OrderedById).HasColumnName("OrderedByID");

                entity.Property(e => e.OrderedByName).HasMaxLength(50);

                entity.Property(e => e.PostedYn).HasColumnName("PostedYN");

                entity.Property(e => e.ShipCarrierId).HasColumnName("ShipCarrierID");

                entity.Property(e => e.StateFiscalYearAbbrev).HasMaxLength(10);

                entity.HasOne(d => d.InventoryAction)
                    .WithMany(p => p.PharmInventoryOuts)
                    .HasForeignKey(d => d.InventoryActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmInventoryOut_PharmInventoryActions");
            });

            modelBuilder.Entity<PharmInventoryOutNoteChoice>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PharmInvOutNoteChoice).HasMaxLength(50);
            });

            modelBuilder.Entity<PharmItemClass>(entity =>
            {
                entity.HasKey(e => e.ItemClassId)
                    .HasName("PK_ItemClasses");

                entity.Property(e => e.ItemClassId)
                    .ValueGeneratedNever()
                    .HasColumnName("ItemClassID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy).HasMaxLength(50);

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ItemClassName).HasMaxLength(50);
            });

            modelBuilder.Entity<PharmItemNdcnum>(entity =>
            {
                entity.HasKey(e => e.ItemPackageNdcnumId)
                    .HasName("PK_PharmItemNDCNum")
                    .IsClustered(false);

                entity.ToTable("PharmItemNDCNums");

                entity.Property(e => e.ItemPackageNdcnumId).HasColumnName("ItemPackageNDCNumID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.Ndcnum)
                    .HasMaxLength(20)
                    .HasColumnName("NDCNum");

                entity.Property(e => e.TradeName).HasMaxLength(50);

                entity.HasOne(d => d.ItemPackage)
                    .WithMany(p => p.PharmItemNdcnums)
                    .HasForeignKey(d => d.ItemPackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmItemNDCNums_PharmItemPackages");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.PharmItemNdcnums)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_PharmItemNDCNums_PharmManufacturers");
            });

            modelBuilder.Entity<PharmItemNdcnumsOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PharmItemNDCNumsOld");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.ItemPackageNdcnumId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ItemPackageNDCNumID");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.Ndcnum)
                    .HasMaxLength(20)
                    .HasColumnName("NDCNum");

                entity.Property(e => e.TradeName).HasMaxLength(50);
            });

            modelBuilder.Entity<PharmItemPackage>(entity =>
            {
                entity.HasKey(e => e.ItemPackageId)
                    .HasName("PharmItemPackages_PK")
                    .IsClustered(false);

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.BinNum).HasMaxLength(10);

                entity.Property(e => e.CurrCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DiscontinuedYn)
                    .HasColumnName("DiscontinuedYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ExcludeFromParLvlRptYn)
                    .HasColumnName("ExcludeFromParLvlRptYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemOriginalId).HasColumnName("ItemOriginalID");

                entity.Property(e => e.LabelledYn)
                    .HasColumnName("LabelledYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastInventoryDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldItemId).HasColumnName("OldItemID");

                entity.Property(e => e.OldItemNum).HasMaxLength(15);

                entity.Property(e => e.OldprogramPayingForId).HasColumnName("OLDProgramPayingForID");

                entity.Property(e => e.OrigPackageFromSupplierYn).HasColumnName("OrigPackageFromSupplierYN");

                entity.Property(e => e.QtyPerPackage).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReorderLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailPrice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StockingLevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tempis340BYn).HasColumnName("TEMPIs340B_YN");

                entity.HasOne(d => d.ItemOriginal)
                    .WithMany(p => p.PharmItemPackages)
                    .HasForeignKey(d => d.ItemOriginalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PharmItemPackages_PharmItemsOriginal");
            });

            modelBuilder.Entity<PharmItemPackageProgram>(entity =>
            {
                entity.HasKey(e => e.ItemProgramId)
                    .HasName("PK_PharmItem340B_Programs");

                entity.Property(e => e.ItemProgramId).HasColumnName("ItemProgramID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PharmItemPackagePrograms)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmItemPackagePrograms_Programs");
            });

            modelBuilder.Entity<PharmItemReturnType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ItemReturnType).HasMaxLength(20);
            });

            modelBuilder.Entity<PharmItemsOriginal>(entity =>
            {
                entity.HasKey(e => e.ItemOriginalId)
                    .HasName("PharmItemsOriginal_PK")
                    .IsClustered(false);

                entity.ToTable("PharmItemsOriginal");

                entity.Property(e => e.ItemOriginalId).HasColumnName("ItemOriginalID");

                entity.Property(e => e.CertificationReqYn)
                    .HasColumnName("CertificationReqYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContainerType).HasMaxLength(15);

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DrugDosageForm).HasMaxLength(20);

                entity.Property(e => e.DrugOrSupply).HasMaxLength(10);

                entity.Property(e => e.DrugStrength).HasMaxLength(10);

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemDescr).HasMaxLength(60);

                entity.Property(e => e.ItemGroup).HasMaxLength(50);

                entity.Property(e => e.OldItemId).HasColumnName("OldItemID");

                entity.Property(e => e.PrescriptionTypeCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.RefrigerateYn)
                    .HasColumnName("RefrigerateYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLotNumYn)
                    .HasColumnName("RequireLotNumYN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(10);

                entity.Property(e => e.Upinum)
                    .HasMaxLength(20)
                    .HasColumnName("UPINum");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PharmItemsOriginals)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_PharmItemsOriginal_PharmSupplierVendors");
            });

            modelBuilder.Entity<PharmItemsReturnedExpiredFromLoc>(entity =>
            {
                entity.HasKey(e => e.ItemReturnedId)
                    .HasName("aaaaaPharmItemsReturnedExpiredFromLoc_PK")
                    .IsClustered(false);

                entity.ToTable("PharmItemsReturnedExpiredFromLoc");

                entity.HasIndex(e => e.ItemPackageId, "ItemID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ItemReturnedId, "ItemReturnedID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.LocationId, "LocationID")
                    .HasFillFactor(100);

                entity.Property(e => e.ItemReturnedId).HasColumnName("ItemReturnedID");

                entity.Property(e => e.Comments).HasColumnType("text");

                entity.Property(e => e.CurrItemCost)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateProcessingComplete).HasColumnType("datetime");

                entity.Property(e => e.DateReceivedFromLoc).HasColumnType("datetime");

                entity.Property(e => e.DateSentForProcessing).HasColumnType("datetime");

                entity.Property(e => e.InventoryInDetailId).HasColumnName("InventoryInDetailID");

                entity.Property(e => e.ItemDescr)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.QtyReturnedExpired).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ReturnType)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.HasOne(d => d.ItemPackage)
                    .WithMany(p => p.PharmItemsReturnedExpiredFromLocs)
                    .HasForeignKey(d => d.ItemPackageId)
                    .HasConstraintName("FK_PharmItemsReturnedExpiredFromLoc_PharmItemPackages");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PharmItemsReturnedExpiredFromLocs)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_PharmItemsReturnedExpiredFromLoc_PharmLocations");
            });

            modelBuilder.Entity<PharmLocation>(entity =>
            {
                entity.HasKey(e => e.LocationId)
                    .HasName("aaaaaPharmLocations_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.Location, "Location")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.LocationCode, "LocationCode")
                    .IsUnique()
                    .HasFillFactor(100);

                entity.HasIndex(e => e.LocationId, "LocationID")
                    .HasFillFactor(100);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ActiveYn)
                    .IsRequired()
                    .HasColumnName("ActiveYN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1).HasMaxLength(40);

                entity.Property(e => e.Address2).HasMaxLength(40);

                entity.Property(e => e.CityLine).HasMaxLength(40);

                entity.Property(e => e.ClinicLicenseClassId).HasColumnName("ClinicLicenseClassID");

                entity.Property(e => e.ClinicLicenseExpDate).HasColumnType("datetime");

                entity.Property(e => e.ClinicLicenseNum).HasMaxLength(10);

                entity.Property(e => e.Contact1Name).HasMaxLength(50);

                entity.Property(e => e.Contact2Name).HasMaxLength(50);

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.LocCity).HasMaxLength(50);

                entity.Property(e => e.LocCloseDate).HasColumnType("datetime");

                entity.Property(e => e.LocOpenDate).HasColumnType("datetime");

                entity.Property(e => e.LocState).HasMaxLength(2);

                entity.Property(e => e.LocZip).HasMaxLength(10);

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.LocationCode).HasMaxLength(10);

                entity.Property(e => e.LocationOldName).HasMaxLength(50);

                entity.Property(e => e.LocationType).HasMaxLength(10);

                entity.Property(e => e.PaShareVendorId)
                    .HasMaxLength(30)
                    .HasColumnName("PA_SHARE_VendorID");

                entity.Property(e => e.PhoneAlt).HasMaxLength(15);

                entity.Property(e => e.PhoneMain).HasMaxLength(15);

                entity.HasOne(d => d.ClinicLicenseClass)
                    .WithMany(p => p.PharmLocations)
                    .HasForeignKey(d => d.ClinicLicenseClassId)
                    .HasConstraintName("FK_PharmLocations_PharmClinicLicenseClasses");
            });

            modelBuilder.Entity<PharmLocation340BRegistration>(entity =>
            {
                entity.HasKey(e => e.Location340BRegId)
                    .HasName("PK_PharmLoc340B_Registrations");

                entity.ToTable("PharmLocation340B_Registrations");

                entity.Property(e => e.Location340BRegId).HasColumnName("Location340B_RegID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.Loc340BProgramId).HasColumnName("Loc340B_ProgramID");

                entity.Property(e => e.Loc340BRegistrationExpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Loc340B_RegistrationExpDate");

                entity.Property(e => e.Loc340BRegistrationNum)
                    .HasMaxLength(20)
                    .HasColumnName("Loc340B_RegistrationNum");

                entity.Property(e => e.Loc340BRegistrationStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Loc340B_RegistrationStartDate");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PharmLocation340BRegistrations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmLocation340B_Registrations_PharmLocations");
            });

            modelBuilder.Entity<PharmLocationPaprogContract>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.PaprogContractId })
                    .HasName("PK_PharmLocationContracts");

                entity.ToTable("PharmLocationPAProgContracts");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PaprogContractId).HasColumnName("PAProgContractID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DateTimeStamp)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.LocationContractId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LocationContractID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PharmLocationPaprogContracts)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmLocationPAProgContracts_PharmLocations");
            });

            modelBuilder.Entity<PharmLocationType>(entity =>
            {
                entity.HasKey(e => e.LocationTypeId)
                    .HasName("PK_PharmLocTypes");

                entity.Property(e => e.LocationTypeId).HasColumnName("LocationTypeID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.LocationType).HasMaxLength(10);
            });

            modelBuilder.Entity<PharmManufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerId)
                    .HasName("PK_PharmManufacturers_1");

                entity.Property(e => e.ManufacturerId).HasColumnName("ManufacturerID");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.ManufacturerName).HasMaxLength(50);

                entity.Property(e => e.ManufacturerNdcprefix)
                    .HasMaxLength(10)
                    .HasColumnName("ManufacturerNDCPrefix");

                entity.Property(e => e.ParentCompanyName).HasMaxLength(50);
            });

            modelBuilder.Entity<PharmOrderedByPerson>(entity =>
            {
                entity.HasKey(e => e.OrderedById)
                    .HasName("aaaaaPharmOrderedByPersons_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.OrderedById, "OrderedByID")
                    .HasFillFactor(100);

                entity.Property(e => e.OrderedById).HasColumnName("OrderedByID");

                entity.Property(e => e.ActiveYn).HasColumnName("ActiveYN");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.OrderedByFirstName).HasMaxLength(50);

                entity.Property(e => e.OrderedByLastName).HasMaxLength(50);

                entity.Property(e => e.OrdererName).HasMaxLength(30);

                entity.Property(e => e.PhoneHome).HasMaxLength(20);
            });

            modelBuilder.Entity<PharmPaprogContract>(entity =>
            {
                entity.HasKey(e => new { e.ProgramId, e.PacontractNum });

                entity.ToTable("PharmPAProgContracts");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.PacontractNum)
                    .HasMaxLength(20)
                    .HasColumnName("PAContractNum");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.PacontractAmt)
                    .HasColumnType("money")
                    .HasColumnName("PAContractAmt");

                entity.Property(e => e.PacontractBeginDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAContractBeginDate");

                entity.Property(e => e.PacontractEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("PAContractEndDate");

                entity.Property(e => e.PaprogContractId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PAProgContractID");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PharmPaprogContracts)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PharmPAProgContracts_Programs");
            });

            modelBuilder.Entity<PharmPreference>(entity =>
            {
                entity.HasKey(e => e.CompanyName)
                    .HasName("aaaaaPharmPreferences_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.DefaultFiscalYearAbbrev, "DefaultFiscalYearAbbrev")
                    .HasFillFactor(100);

                entity.Property(e => e.CompanyName).HasMaxLength(40);

                entity.Property(e => e.Address1).HasMaxLength(40);

                entity.Property(e => e.Address2).HasMaxLength(40);

                entity.Property(e => e.CityLine).HasMaxLength(40);

                entity.Property(e => e.DefaultFiscalYearAbbrev).HasMaxLength(10);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.FedId)
                    .HasMaxLength(20)
                    .HasColumnName("FedID#");

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.TaxRate).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpsizeTs)
                    .IsRowVersion()
                    .IsConcurrencyToken()
                    .HasColumnName("upsize_ts");
            });

            modelBuilder.Entity<PharmPrescriptionType>(entity =>
            {
                entity.HasKey(e => e.PrescriptionTypeCode);

                entity.Property(e => e.PrescriptionTypeCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.PrescriptionTypeDescr).HasMaxLength(30);
            });

            modelBuilder.Entity<PharmShelfLocation>(entity =>
            {
                entity.HasKey(e => e.ShelfLocationCode);

                entity.Property(e => e.ShelfLocationCode).HasMaxLength(25);

                entity.Property(e => e.ShelfLocationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ShelfLocationID");
            });

            modelBuilder.Entity<PharmShipper>(entity =>
            {
                entity.HasKey(e => e.ShipperId)
                    .HasName("aaaaaPharmShippers_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ShipperId, "ShipperID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.ShipperName, "ShipperName")
                    .HasFillFactor(100);

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");

                entity.Property(e => e.ShipperName).HasMaxLength(40);
            });

            modelBuilder.Entity<PharmSupplierVendor>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("aaaaaPharmSupplierVendors_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.SupplierId, "SupplierID")
                    .HasFillFactor(100);

                entity.HasIndex(e => e.SupplierName, "SupplierName")
                    .HasFillFactor(100);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Address1).HasMaxLength(40);

                entity.Property(e => e.Address2).HasMaxLength(40);

                entity.Property(e => e.CityLine).HasMaxLength(40);

                entity.Property(e => e.Contact1Name).HasMaxLength(50);

                entity.Property(e => e.Contact2Name).HasMaxLength(50);

                entity.Property(e => e.DateEntered)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([datetime],CONVERT([varchar],getdate(),(1)),(0)))");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.MainSupplies).HasMaxLength(50);

                entity.Property(e => e.NdclabelerCode)
                    .HasMaxLength(5)
                    .HasColumnName("NDCLabelerCode");

                entity.Property(e => e.Phone1).HasMaxLength(15);

                entity.Property(e => e.Phone2).HasMaxLength(15);

                entity.Property(e => e.SupplierCity).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(40);

                entity.Property(e => e.SupplierState).HasMaxLength(2);

                entity.Property(e => e.SupplierZip).HasMaxLength(10);

                entity.Property(e => e.WarehouseSupplierYn).HasColumnName("WarehouseSupplierYN");
            });

            modelBuilder.Entity<PharmYear>(entity =>
            {
                entity.HasKey(e => e.YearAbbrev)
                    .HasName("aaaaaPharmYears_PK")
                    .IsClustered(false);

                entity.Property(e => e.YearAbbrev).HasMaxLength(10);

                entity.Property(e => e.BeginDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentYn)
                    .IsRequired()
                    .HasColumnName("CurrentYN")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.YearText).HasMaxLength(20);

                entity.Property(e => e.YearType).HasMaxLength(50);
            });

            modelBuilder.Entity<Program>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("aaaaaPharmProgramsPayingForItems_PK")
                    .IsClustered(false);

                entity.HasIndex(e => e.ProgramId, "ProgramID")
                    .IsUnique()
                    .HasFillFactor(100);

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ActiveYn).HasColumnName("ActiveYN");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateModified).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EnteredBy).HasMaxLength(50);

                entity.Property(e => e.EnteredByEmployeeId).HasColumnName("EnteredByEmployeeID");

                entity.Property(e => e.Is340BYn)
                    .HasColumnName("Is340B_YN")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemPrefix).HasMaxLength(2);

                entity.Property(e => e.ProgramAbbrev).HasMaxLength(10);

                entity.Property(e => e.ProgramName).HasMaxLength(50);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Programs)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Programs_Departments");
            });

            modelBuilder.Entity<VwAllInventoryInByItemPackageId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllInventoryInByItemPackageID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");
            });

            modelBuilder.Entity<VwAllInventoryOutByItemPackageId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwAllInventoryOutByItemPackageID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");
            });

            modelBuilder.Entity<VwInvInMinItemPackageId>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvInMinItemPackageIDs");

                entity.Property(e => e.InventoryInId).HasColumnName("InventoryInID");

                entity.Property(e => e.MinItemPackageId).HasColumnName("MinItemPackageID");
            });

            modelBuilder.Entity<VwInvOutItemPackageReceiptsIssued>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwInvOutItemPackageReceiptsIssued");

                entity.Property(e => e.ClinicianName).HasMaxLength(50);

                entity.Property(e => e.DateIssuedShipped).HasColumnType("datetime");

                entity.Property(e => e.InventoryInDetailId).HasColumnName("InventoryInDetailID");

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.IsReceiptItem340BYn).HasColumnName("IsReceiptItem340B_YN");

                entity.Property(e => e.ItemCost).HasColumnType("money");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.LocationCode).HasMaxLength(10);

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.PostedYn).HasColumnName("PostedYN");

                entity.Property(e => e.ProgramAbbrev).HasMaxLength(10);

                entity.Property(e => e.TotalCostThisReceipt).HasColumnType("money");

                entity.Property(e => e.WhereFromOrTo).HasMaxLength(50);
            });

            modelBuilder.Entity<VwItemPackageIds340B>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwItemPackageIDs340B");

                entity.Property(e => e.ItemDescr).HasMaxLength(60);

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.OldItemNum).HasMaxLength(15);

                entity.Property(e => e.OldprogramPayingForId).HasColumnName("OLDProgramPayingForID");

                entity.Property(e => e.Tempis340BYn).HasColumnName("TEMPIs340B_YN");
            });

            modelBuilder.Entity<VwItemQtysOnHandAllItemsSqlview>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwItemQtysOnHandAllItems_SQLViews");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");
            });

            modelBuilder.Entity<VwItemsIssuedSumAllItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwItemsIssuedSumAllItems");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");
            });

            modelBuilder.Entity<VwItemsRcvdSumAllItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwItemsRcvdSumAllItems");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");
            });

            modelBuilder.Entity<VwNewPharmItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwNewPharmItems");

                entity.Property(e => e.CertificationReqYn).HasColumnName("CertificationReqYN");

                entity.Property(e => e.ContainerType).HasMaxLength(15);

                entity.Property(e => e.CurrCost).HasColumnType("money");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DiscontinuedYn).HasColumnName("DiscontinuedYN");

                entity.Property(e => e.DrugDosageForm).HasMaxLength(20);

                entity.Property(e => e.DrugOrSupply).HasMaxLength(10);

                entity.Property(e => e.DrugStrength).HasMaxLength(10);

                entity.Property(e => e.ExcludeFromParLvlRptYn).HasColumnName("ExcludeFromParLvlRptYN");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemDescr).HasMaxLength(60);

                entity.Property(e => e.ItemGroup).HasMaxLength(50);

                entity.Property(e => e.ItemOriginalId).HasColumnName("ItemOriginalID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.LastInventoryDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldItemId).HasColumnName("OldItemID");

                entity.Property(e => e.OldItemNum).HasMaxLength(15);

                entity.Property(e => e.OrigPackageFromSupplierYn).HasColumnName("OrigPackageFromSupplierYN");

                entity.Property(e => e.PrescriptionTypeCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.ProgramAbbrev).HasMaxLength(10);

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ProgramName).HasMaxLength(50);

                entity.Property(e => e.RefrigerateYn).HasColumnName("RefrigerateYN");

                entity.Property(e => e.RequireLotNumYn).HasColumnName("RequireLotNumYN");

                entity.Property(e => e.RetailPrice).HasColumnType("money");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.SupplierName).HasMaxLength(40);

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(10);

                entity.Property(e => e.Upinum)
                    .HasMaxLength(20)
                    .HasColumnName("UPINum");
            });

            modelBuilder.Entity<VwPharmInvOutItemPackageReceiptsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPharmInvOutItemPackageReceiptsAll");

                entity.Property(e => e.CheckedByEmployeeId).HasColumnName("CheckedByEmployeeID");

                entity.Property(e => e.ClinicianId).HasColumnName("ClinicianID");

                entity.Property(e => e.DateChecked).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateFilled).HasColumnType("datetime");

                entity.Property(e => e.DateIssuedShipped).HasColumnType("datetime");

                entity.Property(e => e.DateOrdered).HasColumnType("datetime");

                entity.Property(e => e.FilledByEmployeeId).HasColumnName("FilledByEmployeeID");

                entity.Property(e => e.InvOutItemLineId).HasColumnName("InvOutItemLineID");

                entity.Property(e => e.InvOutItemPackageReceiptId).HasColumnName("InvOutItemPackageReceiptID");

                entity.Property(e => e.InventoryActionId).HasColumnName("InventoryActionID");

                entity.Property(e => e.InventoryInDetailId).HasColumnName("InventoryInDetailID");

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.Is340BYn).HasColumnName("Is340B_YN");

                entity.Property(e => e.IsReceiptItem340BYn).HasColumnName("IsReceiptItem340B_YN");

                entity.Property(e => e.IssueShippedAndLockedYn).HasColumnName("IssueShippedAndLockedYN");

                entity.Property(e => e.IssuedShippedByEmployeeId).HasColumnName("IssuedShippedByEmployeeID");

                entity.Property(e => e.ItemCost).HasColumnType("money");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.OrderedById).HasColumnName("OrderedByID");

                entity.Property(e => e.PostedYn).HasColumnName("PostedYN");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ShipCarrierId).HasColumnName("ShipCarrierID");

                entity.Property(e => e.StateFiscalYearAbbrev).HasMaxLength(10);

                entity.Property(e => e.TotalCostThisItem).HasColumnType("money");

                entity.Property(e => e.TotalCostThisReceipt).HasColumnType("money");
            });

            modelBuilder.Entity<VwPharmItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwPharmItems");

                entity.Property(e => e.CertificationReqYn).HasColumnName("CertificationReqYN");

                entity.Property(e => e.ContainerType).HasMaxLength(15);

                entity.Property(e => e.CurrCost).HasColumnType("money");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DiscontinuedYn).HasColumnName("DiscontinuedYN");

                entity.Property(e => e.DrugDosageForm).HasMaxLength(20);

                entity.Property(e => e.DrugOrSupply).HasMaxLength(10);

                entity.Property(e => e.DrugStrength).HasMaxLength(10);

                entity.Property(e => e.ExcludeFromParLvlRptYn).HasColumnName("ExcludeFromParLvlRptYN");

                entity.Property(e => e.ItemClassId).HasColumnName("ItemClassID");

                entity.Property(e => e.ItemDescr).HasMaxLength(60);

                entity.Property(e => e.ItemGroup).HasMaxLength(50);

                entity.Property(e => e.ItemOriginalId).HasColumnName("ItemOriginalID");

                entity.Property(e => e.ItemPackageId).HasColumnName("ItemPackageID");

                entity.Property(e => e.LabelledYn).HasColumnName("LabelledYN");

                entity.Property(e => e.LastInventoryDate).HasColumnType("datetime");

                entity.Property(e => e.Notes).HasMaxLength(100);

                entity.Property(e => e.OldItemId).HasColumnName("OldItemID");

                entity.Property(e => e.OldItemNum).HasMaxLength(15);

                entity.Property(e => e.OrigPackageFromSupplierYn).HasColumnName("OrigPackageFromSupplierYN");

                entity.Property(e => e.PrescriptionTypeCode)
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.RefrigerateYn).HasColumnName("RefrigerateYN");

                entity.Property(e => e.RequireLotNumYn).HasColumnName("RequireLotNumYN");

                entity.Property(e => e.RetailPrice).HasColumnType("money");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitOfMeasure).HasMaxLength(10);

                entity.Property(e => e.Upinum)
                    .HasMaxLength(20)
                    .HasColumnName("UPINum");
            });

            modelBuilder.Entity<ZzTempForInvOutItemPackagesBackordered>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzTempForInvOutItemPackagesBackordered");

                entity.Property(e => e.InventoryOutId).HasColumnName("InventoryOutID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.NewItemPackageId).HasColumnName("NewItemPackageID");

                entity.Property(e => e.OlditemNum)
                    .HasMaxLength(50)
                    .HasColumnName("OLDItemNum");
            });

            modelBuilder.Entity<ZzTempItemsBo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzTempItemsBO");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.NewItemPackageId).HasColumnName("NewItemPackageID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
