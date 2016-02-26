namespace Pulsar4X.ECSLib
{
    //Taken from Aurora's 7.1 Stevefire.mdb database.
    public enum EventType
    {
        NoEventType,

        #region Shipyard Events

        ShipConstruction,
        ShipRepair,
        ShipRefit,
        ShipOverhaul,
        ShipScrapped,
        
        ShipyardModified,
        OverhaulComplete,
        OverhaulAbandoned,

        SlipwayDestroyed,
        ShipyardDestroyed,

        #endregion

        #region Population Events
        
        PlanetBombarded,
        CollateralDamage,
        MassDriverAttack,

        POWRescued, // Friendly POW's returned to population

        // Political Status Events
        PopulationSurrender,
        PopStatusChange,
        UnrestIncreasing,
        UnrestDecreasing,

        // Mining Events
        MineralExhausted,
        AllMineralsExhausted,
        NewMineralDeposit,
        AccessibilityIncrease,
        MineralsLocated,
        GeoSurveyComplete,

        // Research Events
        ResearchStarted,
        ResearchCompleted,
        InactiveLab,
        OverallocationOfLabs,
        ReductionInLabs,

        // Industry Events
        Production,
        BombardmentLosses,
        MineralShortage,
        ComponentsScrapped,
        FightersScrapped,
        FuelShortage,
        CivilianMiningColony,
        ProductionQueueEmpty,

        // Ground Unit Events
        UnitTrained,
        GroundCombat,
        GroundUnitLost,
        GroundUnitDelivered,
        MoraleIncrease,
        MoraleLoss,
        ReplacementsExpended,
        EnemyCasualties,
        ReadinessLoss,

        // Environment Events
        TerraformingReport,
        GasRemoved,
        IceSheetMelted,
        RadiationIncrease,
        BreathableAtmosphere,

        // Xenology Events
        MineRestored,
        FactoryRestored,
        RuinsExploited,
        TechDiscovered,
        RuinsLocated,
        AnomalyDiscovered,
        RoboticGuardians,
        TechDataLearned,

        #endregion

        #region Leader events

        TeamSkill,
        OfficerUpdate,
        PickupFailed,
        DropoffFailed,
        CommanderDelivered,
        OfficerPromoted,
        OfficerHealth,
        CommandAssignment,

        OutstandingNewOfficer,
        ExceptionalNewOfficer,
        PromisingNewOfficer,
        NewOfficer,

        NewAdministrator,
        NewScientist,

        #endregion

        #region Ship Combat

        ShipSurrender,
        CrewGradeIncrease,

        // Targeting Events
        Targeting,
        TargetingProblemm,
        ChanceToHit,
        TargetHit,
        TargetMissed,
        NoMissileAssigned,
        FireDelay,
        FiringSummary,
        MissilesDestroyed,
        MissileIntercepted,
        InterceptionSummary,
        MissileSelfDestruct,

        // Weapon Events
        WeaponRecharging,
        WeaponReloading,
        SecondStageRelease,
        MissileLaunch,
        OutOfAmmo,

        // Shield Events
        ShieldsInactive,
        ShieldsDown,
        ShieldRechage,
        ShieldFailure,
        ShieldDeactivation,

        // Damage Events
        DamageAbsorbed,
        SystemDestroyed,
        SystemIntact,
        SecondayExplosion,
        ShipDestroyed,
        Damage,
        ShieldDamage,
        ShipSlowed,
        TargetDestroyed,
        SystemFailureAlert,
        SystemDamaged,
        SystemFailure,
        PowerExplosionDetected,
        MgExplosionDetected,
        ShieldExpDetected,
        InternalDamage,
        RammingAttempt,
        ShockDamage,
        EnemyShipDestroyed,
        ShieldPenetrated,

        // Boarding/Troop Deployment
        BoardingAttempt,
        BoardingCombat,
        CrewLosses,
        ShipCaptured,
        PrisonersTaken,
        CombatDrop,



        #endregion

        // Diplomatic Events
        TreatyAgreed,
        TechExchange,
        Communication,
        Diplomacy,
        Reparations,
        
        // Ship State Events
        InsufficientFuel,
        UnableToLand,
        Selfdestruct,
        TransitFailure,
        NoSpareParts,
        SuccessfulRepair,
        LowFuel,
        FuelExhausted,
        MaintenanceProblem,
        HarvesterCapacity,
        WreckSalvaged,
        SalvageFailed,
        LoadingProblem,
        LifeSupportFailure,
        TractorReleased,
        // Crew Morale Events
        CrewMoraleFalling,
        ShoreLeaveComplete,

        // Order Events
        ConditionalOrder,
        ConditionalOrderFailure,
        OrdersAssigned,
        OrdersNotPossible,
        OrdersCompleted,

        // Life Pod Events
        LifePodExpired,
        SearchAndRescue,
        
        // Intelligence Events
        IntelligenceUpdate,
        NewAlienRace,
        NewHostileClass,
        NewHostileShip,

        // Utility Events
        FleetMessage,
        MessageContinued,
        IncrementAdjustment,
        ProgramError,
        Opps,
        
        // Civilian Events
        CivilianActivity,
        CivilianConstruction,
        NewShippingLine,

        // Team Events
        TeamDelivered,
        TeamDisbanded,
        SuccessfulEspionage,
        TeamKilled,
        TeamCaptured,
        EnemyAgentsKilled,
        EnemyAgentsCaptured,
        
        // Sensor Events
        NewHostileContact,
        NewNeutralContact,
        NewFriendlyContact,
        NewAlliedContact,
        MissileContact,
        WreckContact,
        MineralPacketContact,
        GroundForcesContact,
        ShipyardContact,
        CivilianContact,
        HostileTransitDetected,
        ExplosionDetected,
        ShieldsDetected,
        ActiveSensorDetected,
        PopulationDetected,
        ActiveContactLost,
        ThermalContactLost,
        HostileContactUpdate,
        NeutralContactUpdate,
        FriendlyContactUpdate,
        AlliedContactUpdate,
        CivilianContactUpdate,
        EnergyImpactDetected,
        NewThermalContact,
        PDCLocated,
        TargetLost,
        MissilesLost,
        NewWreck,
        WreckDisappeared,

        // Jump Point/Transit Events
        NewJumpConnection,
        NewSystemDiscovered,
        JumpPointFound,

        // Empire Events
        EmpireInDebt,
        SystemSurveyed,

        // Wormhole Events
        NewStableWormhole,
        WormholeMoved,
        WormholeDisappeared,
        
        #region Unknown/Depreciated/Unused

        GeologicalSurveyData, // Depreciated in favor of Mineral Deposit found/accessability increased?

        // Unused Damage events?
        TargetUndamaged,
        WeaponIneffective,
        Overkill,
        WreckComponents,
        NoDamage,
        // Non-implemented/depreciated shipboard fire mechanic?
        Fire,
        FireContained,
        // Non-implemented/depreciated ship exchange?
        SaleOfferWithdrawn,
        ShipForSale,
        Sale,
        Purchase,

        // Non-implemented/depreciated convoy feature? Pre-taskgroup?
        ConvoyCreated,
        ConvoyArrival,

        // Weather events? Are these used in Nebulas?
        IonStormAhead,
        MissilesInNebula,
        DestroyedByStorm,

        // Possible fighter-specific messages. May be depreciated.
        GroupLanded,
        GroupDestroyed,
        FighterCasualties,

        // Likely background events. Never displayed to the player.
        TimeCheck,
        InvalidUnloadSystem,
        AlienFleets,
        AlienPopulation,
        AlienShipRefitted,

        // I have no idea
        FireControlPaint,
        FireControlLockLost,
        JumpGateUnderway,
        GroundUnitDest,
        FullSpares,
        MaintenanceZero,
        TechDownloaded,
        TechDataScanned,
        NoFreighterOverhaul,
        GPDContactLost,
        TechRemoved,
        NegotiationModifier,
        IllegalOrder,
        AlienClassScanned,
        OverhaulClockReduced,
        TrainingReset,
        ParasiteLauncherReady,
        InsufficientJGC,
        PlanetLooted,
        UnsuitablePlanet,
        GovernmentChange, // NPR's don't change government? Player government change isn't recorded?
        FighterAssigned,

        NewAlienClass, // Possibly depreciated in favor of "NewHostileClass"
        NewAlienShip, // Possibly depreciated in favor of "NewHostileShip"
        ProbeOutOfFuel, // Possibly used when missle bouys used fuel?

        JumpGateDetected, // Depreciated for "JumpPointFound"?
        JumpPointDetected, // Depreciated for "JumpPointFound"?

        // Known Depreciated
        ShipMothballed,
        ShipReactivation,
        HyperLimitWarning,

        ItsLifeJim, // Easter Egg Event?

        #endregion
    }
}