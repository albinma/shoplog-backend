using Microsoft.EntityFrameworkCore;

public partial class VpicDbContext : DbContext
{
    public VpicDbContext() { }

    public VpicDbContext(DbContextOptions<VpicDbContext> options)
        : base(options) { }

    public virtual DbSet<Ab> Abs { get; set; }

    public virtual DbSet<AdaptiveCruiseControl> AdaptiveCruiseControls { get; set; }

    public virtual DbSet<AdaptiveDrivingBeam> AdaptiveDrivingBeams { get; set; }

    public virtual DbSet<AirBagLocFront> AirBagLocFronts { get; set; }

    public virtual DbSet<AirBagLocKnee> AirBagLocKnees { get; set; }

    public virtual DbSet<AirBagLocation> AirBagLocations { get; set; }

    public virtual DbSet<AutoBrake> AutoBrakes { get; set; }

    public virtual DbSet<AutoReverseSystem> AutoReverseSystems { get; set; }

    public virtual DbSet<AutomaticPedestrainAlertingSound> AutomaticPedestrainAlertingSounds { get; set; }

    public virtual DbSet<AxleConfiguration> AxleConfigurations { get; set; }

    public virtual DbSet<BatteryType> BatteryTypes { get; set; }

    public virtual DbSet<BedType> BedTypes { get; set; }

    public virtual DbSet<BlindSpotIntervention> BlindSpotInterventions { get; set; }

    public virtual DbSet<BlindSpotMonitoring> BlindSpotMonitorings { get; set; }

    public virtual DbSet<BodyCab> BodyCabs { get; set; }

    public virtual DbSet<BodyStyle> BodyStyles { get; set; }

    public virtual DbSet<BrakeSystem> BrakeSystems { get; set; }

    public virtual DbSet<BusFloorConfigType> BusFloorConfigTypes { get; set; }

    public virtual DbSet<BusType> BusTypes { get; set; }

    public virtual DbSet<CanAacn> CanAacns { get; set; }

    public virtual DbSet<ChargerLevel> ChargerLevels { get; set; }

    public virtual DbSet<Conversion> Conversions { get; set; }

    public virtual DbSet<CoolingType> CoolingTypes { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CustomMotorcycleType> CustomMotorcycleTypes { get; set; }

    public virtual DbSet<DaytimeRunningLight> DaytimeRunningLights { get; set; }

    public virtual DbSet<DecodingOutput> DecodingOutputs { get; set; }

    public virtual DbSet<DefaultValue> DefaultValues { get; set; }

    public virtual DbSet<DestinationMarket> DestinationMarkets { get; set; }

    public virtual DbSet<DriveType> DriveTypes { get; set; }

    public virtual DbSet<DynamicBrakeSupport> DynamicBrakeSupports { get; set; }

    public virtual DbSet<Ec> Ecs { get; set; }

    public virtual DbSet<Edr> Edrs { get; set; }

    public virtual DbSet<ElectrificationLevel> ElectrificationLevels { get; set; }

    public virtual DbSet<Element> Elements { get; set; }

    public virtual DbSet<EngineConfiguration> EngineConfigurations { get; set; }

    public virtual DbSet<EngineModel> EngineModels { get; set; }

    public virtual DbSet<EngineModelPattern> EngineModelPatterns { get; set; }

    public virtual DbSet<EntertainmentSystem> EntertainmentSystems { get; set; }

    public virtual DbSet<ErrorCode> ErrorCodes { get; set; }

    public virtual DbSet<EvdriveUnit> EvdriveUnits { get; set; }

    public virtual DbSet<ForwardCollisionWarning> ForwardCollisionWarnings { get; set; }

    public virtual DbSet<FuelDeliveryType> FuelDeliveryTypes { get; set; }

    public virtual DbSet<FuelType> FuelTypes { get; set; }

    public virtual DbSet<GrossVehicleWeightRating> GrossVehicleWeightRatings { get; set; }

    public virtual DbSet<KeylessIgnition> KeylessIgnitions { get; set; }

    public virtual DbSet<LaneCenteringAssistance> LaneCenteringAssistances { get; set; }

    public virtual DbSet<LaneDepartureWarning> LaneDepartureWarnings { get; set; }

    public virtual DbSet<LaneKeepSystem> LaneKeepSystems { get; set; }

    public virtual DbSet<LowerBeamHeadlampLightSource> LowerBeamHeadlampLightSources { get; set; }

    public virtual DbSet<Make> Makes { get; set; }

    public virtual DbSet<MakeModel> MakeModels { get; set; }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<ManufacturerMake> ManufacturerMakes { get; set; }

    public virtual DbSet<Model> Models { get; set; }

    public virtual DbSet<MotorcycleChassisType> MotorcycleChassisTypes { get; set; }

    public virtual DbSet<MotorcycleSuspensionType> MotorcycleSuspensionTypes { get; set; }

    public virtual DbSet<NonLandUse> NonLandUses { get; set; }

    public virtual DbSet<ParkAssist> ParkAssists { get; set; }

    public virtual DbSet<Pattern> Patterns { get; set; }

    public virtual DbSet<PedestrianAutomaticEmergencyBraking> PedestrianAutomaticEmergencyBrakings { get; set; }

    public virtual DbSet<Pretensioner> Pretensioners { get; set; }

    public virtual DbSet<RearAutomaticEmergencyBraking> RearAutomaticEmergencyBrakings { get; set; }

    public virtual DbSet<RearCrossTrafficAlert> RearCrossTrafficAlerts { get; set; }

    public virtual DbSet<RearVisibilityCamera> RearVisibilityCameras { get; set; }

    public virtual DbSet<SeatBeltsAll> SeatBeltsAlls { get; set; }

    public virtual DbSet<SemiautomaticHeadlampBeamSwitching> SemiautomaticHeadlampBeamSwitchings { get; set; }

    public virtual DbSet<Steering> Steerings { get; set; }

    public virtual DbSet<Tpm> Tpms { get; set; }

    public virtual DbSet<TractionControl> TractionControls { get; set; }

    public virtual DbSet<TrailerBodyType> TrailerBodyTypes { get; set; }

    public virtual DbSet<TrailerType> TrailerTypes { get; set; }

    public virtual DbSet<Transmission> Transmissions { get; set; }

    public virtual DbSet<Turbo> Turbos { get; set; }

    public virtual DbSet<VNcsabodyType> VNcsabodyTypes { get; set; }

    public virtual DbSet<VNcsamake> VNcsamakes { get; set; }

    public virtual DbSet<VNcsamodel> VNcsamodels { get; set; }

    public virtual DbSet<ValvetrainDesign> ValvetrainDesigns { get; set; }

    public virtual DbSet<VehicleSpecPattern> VehicleSpecPatterns { get; set; }

    public virtual DbSet<VehicleSpecSchema> VehicleSpecSchemas { get; set; }

    public virtual DbSet<VehicleSpecSchemaModel> VehicleSpecSchemaModels { get; set; }

    public virtual DbSet<VehicleSpecSchemaYear> VehicleSpecSchemaYears { get; set; }

    public virtual DbSet<VehicleType> VehicleTypes { get; set; }

    public virtual DbSet<VinDescriptor> VinDescriptors { get; set; }

    public virtual DbSet<VinException> VinExceptions { get; set; }

    public virtual DbSet<VinSchema> VinSchemas { get; set; }

    public virtual DbSet<VspecSchemaPattern> VspecSchemaPatterns { get; set; }

    public virtual DbSet<WheelBaseType> WheelBaseTypes { get; set; }

    public virtual DbSet<Wmi> Wmis { get; set; }

    public virtual DbSet<WmiVinSchema> WmiVinSchemas { get; set; }

    public virtual DbSet<WmiyearValidChar> WmiyearValidChars { get; set; }

    public virtual DbSet<WmiyearValidCharsCacheException> WmiyearValidCharsCacheExceptions { get; set; }

    public override Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default
    ) => throw new NotSupportedException("This context is read-only.");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ab>(entity =>
        {
            entity.ToTable("ABS");

            entity.HasIndex(e => e.Name, "U_ABSName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<AdaptiveCruiseControl>(entity =>
        {
            entity.ToTable("AdaptiveCruiseControl");

            entity.HasIndex(e => e.Name, "U_AdaptiveCruiseControlName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<AdaptiveDrivingBeam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Adaptive__3214EC0753F971CF");

            entity.ToTable("AdaptiveDrivingBeam");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<AirBagLocFront>(entity =>
        {
            entity.ToTable("AirBagLocFront");

            entity.HasIndex(e => e.Name, "U_AirBagLocFront_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
        });

        modelBuilder.Entity<AirBagLocKnee>(entity =>
        {
            entity.ToTable("AirBagLocKnee");

            entity.HasIndex(e => e.Name, "U_AirBagLocKnee_Name").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
        });

        modelBuilder.Entity<AirBagLocation>(entity =>
        {
            entity.HasIndex(e => e.Name, "U_AirBagLocName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(50).IsUnicode(false);
        });

        modelBuilder.Entity<AutoBrake>(entity =>
        {
            entity.ToTable("AutoBrake");

            entity.HasIndex(e => e.Name, "U_AEBName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<AutoReverseSystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AutoReve__3214EC07D99B9C79");

            entity.ToTable("AutoReverseSystem");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<AutomaticPedestrainAlertingSound>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Automati__3214EC079A150E03");

            entity.ToTable("AutomaticPedestrainAlertingSound");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<AxleConfiguration>(entity =>
        {
            entity.ToTable("AxleConfiguration");

            entity.HasIndex(e => e.Name, "U_AxleConfiguration").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BatteryType>(entity =>
        {
            entity.ToTable("BatteryType");

            entity.HasIndex(e => e.Name, "U_BatteryTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BedType>(entity =>
        {
            entity.ToTable("BedType");

            entity.HasIndex(e => e.Name, "U_BedTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BlindSpotIntervention>(entity =>
        {
            entity.ToTable("BlindSpotIntervention");

            entity.HasIndex(e => e.Name, "U_BlindSpotIntervention").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BlindSpotMonitoring>(entity =>
        {
            entity.ToTable("BlindSpotMonitoring");

            entity.HasIndex(e => e.Name, "U_BlindSpotMonName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BodyCab>(entity =>
        {
            entity.ToTable("BodyCab");

            entity.HasIndex(e => e.Name, "U_BodyCabTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BodyStyle>(entity =>
        {
            entity.ToTable("BodyStyle");

            entity.HasIndex(e => e.Name, "U_BodyClassName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BrakeSystem>(entity =>
        {
            entity.ToTable("BrakeSystem");

            entity.HasIndex(e => e.Name, "U_BrakeSystemTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BusFloorConfigType>(entity =>
        {
            entity.ToTable("BusFloorConfigType");

            entity.HasIndex(e => e.Name, "IX_BusFloorConfigType").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<BusType>(entity =>
        {
            entity.ToTable("BusType");

            entity.HasIndex(e => e.Name, "IX_BusType").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<CanAacn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAN_AACN__3214EC079657DF7C");

            entity.ToTable("CAN_AACN");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<ChargerLevel>(entity =>
        {
            entity.ToTable("ChargerLevel");

            entity.HasIndex(e => e.Name, "IX_ChargerLevel").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Conversion>(entity =>
        {
            entity.ToTable("Conversion");

            entity.Property(e => e.Formula).HasMaxLength(1000);
        });

        modelBuilder.Entity<CoolingType>(entity =>
        {
            entity.ToTable("CoolingType");

            entity.HasIndex(e => e.Name, "IX_CoolingType").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.ToTable("Country");

            entity.HasIndex(e => e.Name, "U_CountryName").IsUnique();

            entity.Property(e => e.Displayorder).HasDefaultValue(999).HasColumnName("displayorder");
            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<CustomMotorcycleType>(entity =>
        {
            entity.ToTable("CustomMotorcycleType");

            entity.HasIndex(e => e.Name, "IX_CustomMotorcycleType").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<DaytimeRunningLight>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DaytimeR__3214EC07E6E39743");

            entity.ToTable("DaytimeRunningLight");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<DecodingOutput>(entity =>
        {
            entity.ToTable("DecodingOutput");

            entity
                .Property(e => e.AddedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.AttributeId).HasMaxLength(500).IsUnicode(false);
            entity.Property(e => e.Code).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DataType).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Decode).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.GroupName).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Keys).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Source).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Value).HasMaxLength(500).IsUnicode(false);
            entity.Property(e => e.Variable).HasMaxLength(100).IsUnicode(false);
        });

        modelBuilder.Entity<DefaultValue>(entity =>
        {
            entity.ToTable("DefaultValue");

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity
                .Property(e => e.DefaultValue1)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DefaultValue");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity
                .HasOne(d => d.Element)
                .WithMany(p => p.DefaultValues)
                .HasForeignKey(d => d.ElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultValue_ElementId");

            entity
                .HasOne(d => d.VehicleType)
                .WithMany(p => p.DefaultValues)
                .HasForeignKey(d => d.VehicleTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DefaultValue_VehicleTypeId");
        });

        modelBuilder.Entity<DestinationMarket>(entity =>
        {
            entity.ToTable("DestinationMarket");

            entity.HasIndex(e => e.Name, "U_DestinationMarketName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<DriveType>(entity =>
        {
            entity.ToTable("DriveType");

            entity.HasIndex(e => e.Name, "U_DriveTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<DynamicBrakeSupport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DynamicB__3214EC07A7D5E8A9");

            entity.ToTable("DynamicBrakeSupport");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Ec>(entity =>
        {
            entity.ToTable("ECS");

            entity.HasIndex(e => e.Name, "U_ESCName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Edr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__EDR__3214EC07273A4B03");

            entity.ToTable("EDR");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<ElectrificationLevel>(entity =>
        {
            entity.ToTable("ElectrificationLevel");

            entity.HasIndex(e => e.Name, "IX_ElectrificationLevel").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Element>(entity =>
        {
            entity.ToTable("Element");

            entity.HasIndex(e => new { e.Id, e.Name }, "IX_Element");

            entity.HasIndex(e => e.Code, "NonClusteredIndex-20150710-115000");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Code).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.DataType).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Decode).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Description).IsUnicode(false);
            entity.Property(e => e.GroupName).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.IsQs).HasColumnName("IsQS");
            entity.Property(e => e.LookupTable).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100).IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<EngineConfiguration>(entity =>
        {
            entity.ToTable("EngineConfiguration");

            entity.HasIndex(e => e.Name, "U_EngineConfigurationName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<EngineModel>(entity =>
        {
            entity.ToTable("EngineModel");

            entity.Property(e => e.Description).HasMaxLength(500).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500).IsUnicode(false);
        });

        modelBuilder.Entity<EngineModelPattern>(entity =>
        {
            entity.ToTable("EngineModelPattern");

            entity
                .HasIndex(
                    e => new { e.EngineModelId, e.ElementId },
                    "IX_EngineModelPattern_KeyElement_Unique"
                )
                .IsUnique();

            entity.Property(e => e.AttributeId).HasMaxLength(500).IsUnicode(false);
            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity
                .HasOne(d => d.EngineModel)
                .WithMany(p => p.EngineModelPatterns)
                .HasForeignKey(d => d.EngineModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EngineModelPattern_EngineModel");
        });

        modelBuilder.Entity<EntertainmentSystem>(entity =>
        {
            entity.ToTable("EntertainmentSystem");

            entity.HasIndex(e => e.Name, "U_EntertainmentSystemName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<ErrorCode>(entity =>
        {
            entity.ToTable("ErrorCode");

            entity.HasIndex(e => e.Name, "IX_Name").IsUnique();

            entity.Property(e => e.AdditionalErrorText).HasMaxLength(500).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(500).IsUnicode(false);
            entity.Property(e => e.Weight).HasColumnName("weight");
        });

        modelBuilder.Entity<EvdriveUnit>(entity =>
        {
            entity.ToTable("EVDriveUnit");

            entity.HasIndex(e => e.Name, "U_EVDriveUnitName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<ForwardCollisionWarning>(entity =>
        {
            entity.ToTable("ForwardCollisionWarning");

            entity.HasIndex(e => e.Name, "U_ForwardCollisionWarningName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<FuelDeliveryType>(entity =>
        {
            entity.ToTable("FuelDeliveryType");

            entity.HasIndex(e => e.Name, "U_FuelInjectionTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<FuelType>(entity =>
        {
            entity.ToTable("FuelType");

            entity.HasIndex(e => e.Name, "U_FuelTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<GrossVehicleWeightRating>(entity =>
        {
            entity.ToTable("GrossVehicleWeightRating");

            entity.HasIndex(e => e.Name, "U_GVWRName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<KeylessIgnition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KeylessI__3214EC0729E1CCCB");

            entity.ToTable("KeylessIgnition");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<LaneCenteringAssistance>(entity =>
        {
            entity.ToTable("LaneCenteringAssistance");

            entity.HasIndex(e => e.Name, "U_LaneCenteringAssistance").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<LaneDepartureWarning>(entity =>
        {
            entity.ToTable("LaneDepartureWarning");

            entity.HasIndex(e => e.Name, "U_LaneDepartureWarningName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<LaneKeepSystem>(entity =>
        {
            entity.ToTable("LaneKeepSystem");

            entity.HasIndex(e => e.Name, "U_LaneKeepSystemName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<LowerBeamHeadlampLightSource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LowerBea__3214EC077A78C7A5");

            entity.ToTable("LowerBeamHeadlampLightSource");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Make>(entity =>
        {
            entity.ToTable("Make");

            entity.HasIndex(e => e.Name, "IX_Make");

            entity.HasIndex(e => e.Name, "U_MakeName").IsUnique();

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MakeModel>(entity =>
        {
            entity.ToTable("Make_Model");

            entity.HasIndex(e => new { e.MakeId, e.ModelId }, "IX_Make_Model");

            entity.HasIndex(e => e.MakeId, "IX_Make_Model_MakeId");

            entity.HasIndex(e => e.ModelId, "IX_Make_Model_ModelId");

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity
                .HasOne(d => d.Make)
                .WithMany(p => p.MakeModels)
                .HasForeignKey(d => d.MakeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Make_Model_Make");

            entity
                .HasOne(d => d.Model)
                .WithMany(p => p.MakeModels)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Make_Model_Model");
        });

        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.ToTable("Manufacturer");

            entity.HasIndex(e => e.Name, "IX_Manufacturer");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<ManufacturerMake>(entity =>
        {
            entity.ToTable("Manufacturer_Make");

            entity
                .HasIndex(e => new { e.MakeId, e.ManufacturerId }, "IX_Manufacturer_Make")
                .IsUnique();
        });

        modelBuilder.Entity<Model>(entity =>
        {
            entity.ToTable("Model");

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<MotorcycleChassisType>(entity =>
        {
            entity.ToTable("MotorcycleChassisType");

            entity.HasIndex(e => e.Name, "IX_MotorcycleChassisType").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<MotorcycleSuspensionType>(entity =>
        {
            entity.ToTable("MotorcycleSuspensionType");

            entity.HasIndex(e => e.Name, "IX_MotorcycleSuspensionType").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<NonLandUse>(entity =>
        {
            entity.ToTable("NonLandUse");

            entity.HasIndex(e => e.Name, "U_NonLandUseName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<ParkAssist>(entity =>
        {
            entity.ToTable("ParkAssist");

            entity.HasIndex(e => e.Name, "U_ParkAssistName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Pattern>(entity =>
        {
            entity.ToTable("Pattern");

            entity.HasIndex(e => e.VinSchemaId, "IX_Pattern");

            entity
                .HasIndex(
                    e => new
                    {
                        e.VinSchemaId,
                        e.Keys,
                        e.ElementId
                    },
                    "IX_Pattern_KeyElement_Unique"
                )
                .IsUnique();

            entity.HasIndex(e => e.ElementId, "NonClusteredIndex-20150710-113712");

            entity.HasIndex(
                e => new { e.CreatedOn, e.UpdatedOn },
                "NonClusteredIndex-20160721-081119"
            );

            entity.Property(e => e.AttributeId).HasMaxLength(500).IsUnicode(false);
            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Keys).HasMaxLength(50).IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity
                .HasOne(d => d.Element)
                .WithMany(p => p.Patterns)
                .HasForeignKey(d => d.ElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pattern_Element");

            entity
                .HasOne(d => d.VinSchema)
                .WithMany(p => p.Patterns)
                .HasForeignKey(d => d.VinSchemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pattern_VinSchema");
        });

        modelBuilder.Entity<PedestrianAutomaticEmergencyBraking>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedestri__3214EC07A638BA23");

            entity.ToTable("PedestrianAutomaticEmergencyBraking");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Pretensioner>(entity =>
        {
            entity.ToTable("Pretensioner");

            entity.HasIndex(e => e.Name, "U_PretensionerName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<RearAutomaticEmergencyBraking>(entity =>
        {
            entity.ToTable("RearAutomaticEmergencyBraking");

            entity.HasIndex(e => e.Name, "U_RearAutomaticEmergencyBraking").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<RearCrossTrafficAlert>(entity =>
        {
            entity.ToTable("RearCrossTrafficAlert");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<RearVisibilityCamera>(entity =>
        {
            entity.ToTable("RearVisibilityCamera");

            entity.HasIndex(e => e.Name, "U_RearVisibilityCameraName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<SeatBeltsAll>(entity =>
        {
            entity.ToTable("SeatBeltsAll");

            entity.HasIndex(e => e.Name, "U_SeatBeltsAllName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<SemiautomaticHeadlampBeamSwitching>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Semiauto__3214EC071068B17A");

            entity.ToTable("SemiautomaticHeadlampBeamSwitching");

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Steering>(entity =>
        {
            entity.ToTable("Steering");

            entity.HasIndex(e => e.Name, "U_SteeringLocationName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Tpm>(entity =>
        {
            entity.ToTable("TPMS");

            entity.HasIndex(e => e.Name, "IX_TPMS").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<TractionControl>(entity =>
        {
            entity.ToTable("TractionControl");

            entity.HasIndex(e => e.Name, "U_TractionControlName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<TrailerBodyType>(entity =>
        {
            entity.ToTable("TrailerBodyType");

            entity.HasIndex(e => e.Name, "U_TrailerBodyTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<TrailerType>(entity =>
        {
            entity.ToTable("TrailerType");

            entity.HasIndex(e => e.Name, "U_TrailerTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Transmission>(entity =>
        {
            entity.ToTable("Transmission");

            entity.HasIndex(e => e.Name, "U_TransmissionStyleName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Turbo>(entity =>
        {
            entity.ToTable("Turbo");

            entity.HasIndex(e => e.Name, "U_TurboName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<VNcsabodyType>(entity =>
        {
            entity.HasNoKey().ToTable("vNCSABodyType");

            entity.Property(e => e.Name).HasMaxLength(500).IsUnicode(false);
        });

        modelBuilder.Entity<VNcsamake>(entity =>
        {
            entity.HasNoKey().ToTable("vNCSAMake");

            entity.Property(e => e.Name).HasMaxLength(35).IsUnicode(false);
        });

        modelBuilder.Entity<VNcsamodel>(entity =>
        {
            entity.HasNoKey().ToTable("vNCSAModel");

            entity.Property(e => e.Name).HasMaxLength(300).IsUnicode(false);
        });

        modelBuilder.Entity<ValvetrainDesign>(entity =>
        {
            entity.ToTable("ValvetrainDesign");

            entity.HasIndex(e => e.Name, "U_ValveTrainDesignName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<VehicleSpecPattern>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VehicleData_NotWmiRelated");

            entity.ToTable("VehicleSpecPattern");

            entity.HasIndex(
                e => new
                {
                    e.IsKey,
                    e.ElementId,
                    e.AttributeId
                },
                "IX_VehicleSpecPattern"
            );

            entity.HasIndex(e => e.VspecSchemaPatternId, "IX_VehicleSpecPattern_IsKey_EID_AttrID");

            entity.Property(e => e.AttributeId).HasMaxLength(500).IsUnicode(false);
            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.VspecSchemaPatternId).HasColumnName("VSpecSchemaPatternId");

            entity
                .HasOne(d => d.Element)
                .WithMany(p => p.VehicleSpecPatterns)
                .HasForeignKey(d => d.ElementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VehicleData_NotWmiRelated_Element");
        });

        modelBuilder.Entity<VehicleSpecSchema>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_VehicleSpec");

            entity.ToTable("VehicleSpecSchema");

            entity.HasIndex(
                e => new { e.MakeId, e.VehicleTypeId },
                "IX_VehicleSpecSchema_VehicleTypeId_MakeId"
            );

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255).IsUnicode(false);
            entity.Property(e => e.Source).HasMaxLength(250).IsUnicode(false);
            entity.Property(e => e.SourceDate).HasColumnType("datetime");
            entity.Property(e => e.TobeQced).HasColumnName("TobeQCed");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Url).HasMaxLength(250).IsUnicode(false).HasColumnName("URL");
        });

        modelBuilder.Entity<VehicleSpecSchemaModel>(entity =>
        {
            entity.ToTable("VehicleSpecSchema_Model");
        });

        modelBuilder.Entity<VehicleSpecSchemaYear>(entity =>
        {
            entity.ToTable("VehicleSpecSchema_Year");

            entity.HasIndex(
                e => new { e.VehicleSpecSchemaId, e.Year },
                "IX_VehicleSpecSchema_Year"
            );
        });

        modelBuilder.Entity<VehicleType>(entity =>
        {
            entity.ToTable("VehicleType");

            entity.HasIndex(e => e.Name, "U_VehicleTypeName").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(4000).IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<VinDescriptor>(entity =>
        {
            entity.ToTable("VinDescriptor");

            entity.HasIndex(e => e.Descriptor, "IX_VinDescriptor_Descriptor").IsUnique();

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Descriptor).HasMaxLength(17).IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VinException>(entity =>
        {
            entity.ToTable("VinException");

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Vin).HasMaxLength(17).IsUnicode(false).HasColumnName("VIN");
        });

        modelBuilder.Entity<VinSchema>(entity =>
        {
            entity.ToTable("VinSchema");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(255).IsUnicode(false);
            entity.Property(e => e.Notes).IsUnicode(false);
            entity
                .Property(e => e.Sourcewmi)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("sourcewmi");
            entity.Property(e => e.TobeQced).HasColumnName("TobeQCed");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<VspecSchemaPattern>(entity =>
        {
            entity.ToTable("VSpecSchemaPattern");

            entity
                .HasOne(d => d.Schema)
                .WithMany(p => p.VspecSchemaPatterns)
                .HasForeignKey(d => d.SchemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VSpecSchema_VSpecPattern_VehicleSpecSchema");
        });

        modelBuilder.Entity<WheelBaseType>(entity =>
        {
            entity.ToTable("WheelBaseType");

            entity.HasIndex(e => e.Name, "U_WheelBaseTypeName").IsUnique();

            entity.Property(e => e.Name).HasMaxLength(250).IsUnicode(false);
        });

        modelBuilder.Entity<Wmi>(entity =>
        {
            entity.ToTable("Wmi");

            entity.HasIndex(e => e.Wmi1, "IX_Wmi").IsUnique();

            entity.HasIndex(e => e.ManufacturerId, "NonClusteredIndex-20150710-115134");

            entity.HasIndex(e => e.VehicleTypeId, "NonClusteredIndex-20150710-115154");

            entity.HasIndex(
                e => new { e.Wmi1, e.PublicAvailabilityDate },
                "NonClusteredIndex-20150726-231147"
            );

            entity.HasIndex(e => e.Wmi1, "NonClusteredIndex-20150726-231207");

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NonCompliant).HasDefaultValue(false);
            entity.Property(e => e.NonCompliantReason).HasMaxLength(4000).IsUnicode(false);
            entity
                .Property(e => e.NonCompliantSetByOvsc)
                .HasDefaultValue(false)
                .HasColumnName("NonCompliantSetByOVSC");
            entity.Property(e => e.ProcessedOn).HasColumnType("datetime");
            entity.Property(e => e.PublicAvailabilityDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
            entity.Property(e => e.Wmi1).HasMaxLength(6).IsUnicode(false).HasColumnName("Wmi");

            entity
                .HasOne(d => d.Manufacturer)
                .WithMany(p => p.Wmis)
                .HasForeignKey(d => d.ManufacturerId)
                .HasConstraintName("FK_Wmi_Manufacturer");

            entity
                .HasOne(d => d.VehicleType)
                .WithMany(p => p.Wmis)
                .HasForeignKey(d => d.VehicleTypeId)
                .HasConstraintName("FK_Wmi_VehicleType");

            entity
                .HasMany(d => d.Makes)
                .WithMany(p => p.Wmis)
                .UsingEntity<Dictionary<string, object>>(
                    "WmiMake",
                    r =>
                        r.HasOne<Make>()
                            .WithMany()
                            .HasForeignKey("MakeId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Wmi_Make_Make"),
                    l =>
                        l.HasOne<Wmi>()
                            .WithMany()
                            .HasForeignKey("WmiId")
                            .OnDelete(DeleteBehavior.ClientSetNull)
                            .HasConstraintName("FK_Wmi_Make_Wmi"),
                    j =>
                    {
                        j.HasKey("WmiId", "MakeId");
                        j.ToTable("Wmi_Make");
                        j.HasIndex(new[] { "MakeId" }, "IX_Wmi_Make_MakeId");
                    }
                );
        });

        modelBuilder.Entity<WmiVinSchema>(entity =>
        {
            entity.ToTable("Wmi_VinSchema");

            entity
                .HasIndex(
                    e => new
                    {
                        e.VinSchemaId,
                        e.WmiId,
                        e.YearFrom
                    },
                    "IX_Wmi_VinSchema"
                )
                .IsUnique();

            entity.HasIndex(e => e.WmiId, "NonClusteredIndex-20150710-115058");

            entity.HasIndex(e => e.VinSchemaId, "NonClusteredIndex-20150710-115235");

            entity.HasIndex(e => e.VinSchemaId, "NonClusteredIndex-20221116-134353");

            entity
                .HasOne(d => d.VinSchema)
                .WithMany(p => p.WmiVinSchemas)
                .HasForeignKey(d => d.VinSchemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Wmi_VinSchema_VinSchema");

            entity
                .HasOne(d => d.Wmi)
                .WithMany(p => p.WmiVinSchemas)
                .HasForeignKey(d => d.WmiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Wmi_VinSchema_Wmi");
        });

        modelBuilder.Entity<WmiyearValidChar>(entity =>
        {
            entity.ToTable("WMIYearValidChars");

            entity.HasIndex(e => e.Wmi, "IX_WMIValidChars");

            entity.HasIndex(e => new { e.Wmi, e.Year }, "IX_WMIYearValidChars");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Char).HasMaxLength(1).IsUnicode(false);
            entity.Property(e => e.Wmi).HasMaxLength(10).IsUnicode(false).HasColumnName("WMI");
        });

        modelBuilder.Entity<WmiyearValidCharsCacheException>(entity =>
        {
            entity.HasNoKey().ToTable("WMIYearValidChars_CacheExceptions");

            entity.HasIndex(e => e.Wmi, "IX_WMIYearValidChars_CacheExceptions_WMI");

            entity
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Wmi).HasMaxLength(6).IsUnicode(false).HasColumnName("WMI");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
