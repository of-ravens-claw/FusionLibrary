﻿using System;

namespace FusionLibrary
{
    public class FusionEnums
    {
        /// <summary>
        /// Running direction of an entity.
        /// </summary>
        public enum RunningDirection
        {
            Forward,
            Stop,
            Backward
        }

        /// <summary>
        /// Switch types for <see cref="PlayerSwitch"/>.
        /// </summary>
        public enum SwitchTypes
        {
            Auto,
            Long,
            Medium,
            Short
        };

        /// <summary>
        /// Type of particle.
        /// </summary>
        public enum ParticleType
        {
            NonLooped,
            Looped,
            ForceLooped
        }

        /// <summary>
        /// Type of interactive prop.
        /// </summary>
        public enum InteractionType
        {
            Lever,
            Button,
            Toggle
        }

        /// <summary>
        /// Camera types for <see cref="TimedEvent"/>.
        /// </summary>
        public enum CameraType
        {
            Position,
            Entity,
            Custom
        }

        /// <summary>
        /// Types of decors that can be used as <see cref="Decorator"/>.
        /// </summary>
        public enum DecorType
        {
            Float = 1,
            Bool,
            Int,
            Unk,
            Time,
            Vector3,
            DateTime
        }

        /// <summary>
        /// Available script timers. 
        /// </summary>
        public enum ScriptTimer
        {
            A,
            B
        }

        /// <summary>
        /// Cartesian coordinates.
        /// </summary>
        public enum Coordinate
        {
            X,
            Y,
            Z
        }

        /// <summary>
        /// Spawn flags.
        /// </summary>
        [Flags]
        public enum SpawnFlags
        {
            Default = 0,
            WarpPlayer = 1,
            NoPosition = 2,
            NoProperties = 4,
            Broken = 8,
            ForceReentry = 16,
            CheckExists = 32,
            NoOccupants = 64,
            NoVelocity = 128,
            New = 256,
            SetRotation = 512,
            NoWheels = 1024,
            NoMods = 2048,
            NoDriver = 4096,
            NoPlayer = 8192
        }

        /// <summary>
        /// Camera switch types for <see cref="CustomCamera"/>.
        /// </summary>
        public enum CameraSwitchType
        {
            Instant,
            Animated
        }

        /// <summary>
        /// Lights modes of <see cref="GTA.Vehicle"/>.
        /// </summary>
        public enum LightsMode
        {
            Default,
            Disabled,
            AlwaysOn
        }

        public enum MapArea
        {
            County = 2072609373,
            City = -289320599
        }

        /// <summary>
        /// Alpha levels for entities.
        /// </summary>
        public enum AlphaLevel
        {
            L0 = 0,
            L1 = 51,
            L2 = 102,
            L3 = 153,
            L4 = 204,
            L5 = 255
        }

        /// <summary>
        /// Animation types for <see cref="AnimationTypeSettings"/>.
        /// </summary>
        public enum AnimationType
        {
            Offset,
            Rotation
        }

        /// <summary>
        /// Animation steps for <see cref="AnimationStep"/>.
        /// </summary>
        public enum AnimationStep
        {
            Off,
            First,
            Second,
            Third,
            Fourth,
            Fifth,
            Sixth,
            Seventh
        }

        /// <summary>
        /// Input types for <see cref="FusionUtils.ParseFromRawString(string, DateTime, out InputType)"/>.
        /// </summary>
        public enum InputType
        {
            Full,
            Date,
            Time,
            Error
        }

        /// <summary>
        /// Drive actions for <see cref="TaskDrive"/>.
        /// </summary>
        public enum DriveAction
        {
            None = -1,
            BrakeWeak = 1,
            BrakeAndReverse = 3,
            TurnLeft90AndBraking = 4,
            TurnRight90AndBraking = 5,
            HandrakeUntilEnd = 6,
            TurnLeftAndAccelerate = 7,
            TurnRightAndAccelerate = 8,
            AccelerateWeak = 9,
            TurnLeftAndRestoreWheel = 10,
            TurnRightAndRestoreWheel = 11,
            TurnLeftAndReverse = 13,
            TurnRightAndReverse = 14,
            BrakeStrongAndTurn = 19,
            BrakeWeakAndTurnLeftThenTurnRight = 20,
            BrakeWeakAndTurnRightThenTurnLeft = 21,
            BrakeAndReverse2 = 22,
            AccelerateFast = 23,
            BrakeStrong = 24,
            BrakeThenTurnLeftWhenStopping = 25,
            BrakeThenTurnRightWhenStopping = 26,
            BrakeUntilTimeEndsOrCarStops = 27,
            BrakeAndReverseStrong = 28,
            BrakeUntilStopAndBurnout = 30,
            AccelerateAndHandbrake = 31,
            AccelerateVeryStrong = 32
        }

        /// <summary>
        /// Garage doors IDs.
        /// </summary>
        public enum GarageDoor : uint
        {
            MichaelBeverlyHills = 360562957,
            TrevorCountryside = 2175093583,
            TrevorCity = 3774828611,
            TrevorStripclub = 1066626361,
            FranklinAunt = 4019785634,
            FranklinHills = 2393745202,
            Lockup_PSY_01 = 1335986502,
            Lockup_PSY_02 = 800999792,
            Lockup_PSY_03 = 577351367,
            Lockup_CSY_01 = 843505453,
            Lockup_CSY_02 = 320774365,
            Lockup_CSY_03 = 80217136,
            Lockup_CMS_01 = 3782144472,
            Lockup_CMS_02 = 4093351613,
            Lockup_CMS_03 = 1029581185,
            MP_GAR_SIMEON = 1215605247
        }

        /// <summary>
        /// Garage door states.
        /// </summary>
        public enum DoorState
        {
            Unknown = -1,
            Unlocked = 0,
            Locked = 1,
            LockedUntilOutOfArea = 2,
            UnlockedUntilOutOfArea = 3,
            LockedThisFrame = 4,
            OpenThisFrame = 5,
            ClosedThisFrame = 6
        }

        /// <summary>
        /// Task types for <see cref="GTA.Ped"/>.
        /// </summary>
        public enum TaskType
        {
            HandsUp = 0,
            ClimbLadder = 1,
            ExitVehicle = 2,
            CombatRoll = 3,
            AimGunOnFoot = 4,
            MovePlayer = 5,
            PlayerOnFoot = 6,
            Weapon = 8,
            PlayerWeapon = 9,
            PlayerIdles = 10,
            AimGun = 12,
            Complex = 12,
            FSMClone = 12,
            MotionBase = 12,
            Move = 12,
            MoveBase = 12,
            NMBehaviour = 12,
            NavBase = 12,
            Scenario = 12,
            SearchBase = 12,
            SearchInVehicleBase = 12,
            ShockingEvent = 12,
            TrainBase = 12,
            VehicleFSM = 12,
            VehicleGoTo = 12,
            VehicleMissionBase = 12,
            VehicleTempAction = 12,
            Pause = 14,
            DoNothing = 15,
            GetUp = 16,
            GetUpAndStandStill = 17,
            FallOver = 18,
            FallAndGetUp = 19,
            Crawl = 20,
            ComplexOnFire = 25,
            DamageElectric = 26,
            TriggerLookAt = 28,
            ClearLookAt = 29,
            SetCharDecisionMaker = 30,
            SetPedDefensiveArea = 31,
            UseSequence = 32,
            MoveStandStill = 34,
            ComplexControlMovement = 35,
            MoveSequence = 36,
            AmbientClips = 38,
            MoveInAir = 39,
            NetworkClone = 40,
            UseClimbOnRoute = 41,
            UseDropDownOnRoute = 42,
            UseLadderOnRoute = 43,
            SetBlockingOfNonTemporaryEvents = 44,
            ForceMotionState = 45,
            SlopeScramble = 46,
            GoToAndClimbLadder = 47,
            ClimbLadderFully = 48,
            Rappel = 49,
            Vault = 50,
            DropDown = 51,
            AffectSecondaryBehaviour = 52,
            AmbientLookAtEvent = 53,
            OpenDoor = 54,
            ShovePed = 55,
            SwapWeapon = 56,
            GeneralSweep = 57,
            Police = 58,
            PoliceOrderResponse = 59,
            PursueCriminal = 60,
            ArrestPed = 62,
            ArrestPed2 = 63,
            Busted = 64,
            FirePatrol = 65,
            HeliOrderResponse = 66,
            HeliPassengerRappel = 67,
            AmbulancePatrol = 68,
            PoliceWantedResponse = 69,
            Swat = 70,
            SwatWantedResponse = 72,
            SwatOrderResponse = 73,
            SwatGoToStagingArea = 74,
            SwatFollowInLine = 75,
            Witness = 76,
            GangPatrol = 77,
            Army = 78,
            ShockingEventWatch = 80,
            ShockingEventGoto = 82,
            ShockingEventHurryAway = 83,
            ShockingEventReactToAircraft = 84,
            ShockingEventReact = 85,
            ShockingEventBackAway = 86,
            ShockingPoliceInvestigate = 87,
            ShockingEventStopAndStare = 88,
            ShockingNiceCarPicture = 89,
            ShockingEventThreatResponse = 90,
            TakeOffHelmet = 92,
            CarReactToVehicleCollision = 93,
            CarReactToVehicleCollisionGetOut = 95,
            DyingDead = 97,
            WanderingScenario = 100,
            WanderingInRadiusScenario = 101,
            MoveBetweenPointsScenario = 103,
            ChatScenario = 104,
            CowerScenario = 106,
            DeadBodyScenario = 107,
            SayAudio = 114,
            WaitForSteppingOut = 116,
            CoupleScenario = 117,
            UseScenario = 118,
            UseVehicleScenario = 119,
            Unalerted = 120,
            StealVehicle = 121,
            ReactToPursuit = 122,
            HitWall = 125,
            Cower = 126,
            Crouch = 127,
            Melee = 128,
            MoveMeleeMovement = 129,
            MeleeActionResult = 130,
            MeleeUpperbodyAnims = 131,
            MoVEScripted = 133,
            ScriptedAnimation = 134,
            SynchronizedScene = 135,
            ComplexEvasiveStep = 137,
            WalkRoundCarWhileWandering = 138,
            ComplexStuckInAir = 140,
            WalkRoundEntity = 141,
            MoveWalkRoundVehicle = 142,
            ReactToGunAimedAt = 144,
            DuckAndCover = 146,
            AggressiveRubberneck = 147,
            InVehicleBasic = 150,
            CarDriveWander = 151,
            LeaveAnyCar = 152,
            ComplexGetOffBoat = 153,
            CarSetTempAction = 155,
            BringVehicleToHalt = 156,
            CarDrive = 157,
            PlayerDrive = 159,
            EnterVehicle = 160,
            EnterVehicleAlign = 161,
            OpenVehicleDoorFromOutside = 162,
            EnterVehicleSeat = 163,
            CloseVehicleDoorFromInside = 164,
            InVehicleSeatShuffle = 165,
            ExitVehicleSeat = 167,
            CloseVehicleDoorFromOutside = 168,
            ControlVehicle = 169,
            MotionInAutomobile = 170,
            MotionOnBicycle = 171,
            MotionOnBicycleController = 172,
            MotionInVehicle = 173,
            MotionInTurret = 174,
            ReactToBeingJacked = 175,
            ReactToBeingAskedToLeaveVehicle = 176,
            TryToGrabVehicleDoor = 177,
            GetOnTrain = 178,
            GetOffTrain = 179,
            RideTrain = 180,
            MountThrowProjectile = 190,
            GoToCarDoorAndStandStill = 195,
            MoveGoToVehicleDoor = 196,
            SetPedInVehicle = 197,
            SetPedOutOfVehicle = 198,
            VehicleMountedWeapon = 199,
            VehicleGun = 200,
            VehicleProjectile = 201,
            SmashCarWindow = 204,
            MoveGoToPoint = 205,
            MoveAchieveHeading = 206,
            MoveFaceTarget = 207,
            ComplexGoToPointAndStandStillTimed = 208,
            MoveGoToPointAndStandStill = 208,
            MoveFollowPointRoute = 209,
            MoveSeekEntity_CEntitySeekPosCalculatorStandard = 210,
            MoveSeekEntity_CEntitySeekPosCalculatorLastNavMeshIntersection = 211,
            MoveSeekEntity_CEntitySeekPosCalculatorLastNavMeshIntersection2 = 212,
            MoveSeekEntity_CEntitySeekPosCalculatorXYOffsetFixed = 213,
            MoveSeekEntity_CEntitySeekPosCalculatorXYOffsetFixed2 = 214,
            ExhaustedFlee = 215,
            GrowlAndFlee = 216,
            ScenarioFlee = 217,
            SmartFlee = 218,
            FlyAway = 219,
            WalkAway = 220,
            Wander = 221,
            WanderInArea = 222,
            FollowLeaderInFormation = 223,
            GoToPointAnyMeans = 224,
            TurnToFaceEntityOrCoord = 225,
            FollowLeaderAnyMeans = 226,
            FlyToPoint = 228,
            FlyingWander = 229,
            GoToPointAiming = 230,
            GoToScenario = 231,
            SeekEntityAiming = 233,
            SlideToCoord = 234,
            SwimmingWander = 235,
            MoveTrackingEntity = 237,
            MoveFollowNavMesh = 238,
            MoveGoToPointOnRoute = 239,
            EscapeBlast = 240,
            MoveWander = 241,
            MoveBeInFormation = 242,
            MoveCrowdAroundLocation = 243,
            MoveCrossRoadAtTrafficLights = 244,
            MoveWaitForTraffic = 245,
            MoveGoToPointStandStillAchieveHeading = 246,
            MoveGetOntoMainNavMesh = 251,
            MoveSlideToCoord = 252,
            MoveGoToPointRelativeToEntityAndStandStill = 253,
            HelicopterStrafe = 254,
            GetOutOfWater = 256,
            MoveFollowEntityOffset = 259,
            FollowWaypointRecording = 261,
            MotionPed = 264,
            MotionPedLowLod = 265,
            HumanLocomotion = 268,
            MotionBasicLocomotionLowLod = 269,
            MotionStrafing = 270,
            MotionTennis = 271,
            MotionAiming = 272,
            BirdLocomotion = 273,
            FlightlessBirdLocomotion = 274,
            FishLocomotion = 278,
            QuadLocomotion = 279,
            MotionDiving = 280,
            MotionSwimming = 281,
            MotionParachuting = 282,
            MotionDrunk = 283,
            RepositionMove = 284,
            MotionAimingTransition = 285,
            ThrowProjectile = 286,
            Cover = 287,
            MotionInCover = 288,
            AimAndThrowProjectile = 289,
            Gun = 290,
            AimFromGround = 291,
            AimGunVehicleDriveBy = 295,
            AimGunScripted = 296,
            ReloadGun = 298,
            WeaponBlocked = 299,
            EnterCover = 300,
            ExitCover = 301,
            AimGunFromCoverIntro = 302,
            AimGunFromCoverOutro = 303,
            AimGunBlindFire = 304,
            CombatClosestTargetInArea = 307,
            CombatAdditionalTask = 308,
            InCover = 309,
            AimSweep = 313,
            SharkCircle = 318,
            SharkAttack = 319,
            Agitated = 320,
            AgitatedAction = 321,
            Confront = 322,
            Intimidate = 323,
            Shove = 324,
            Shoved = 325,
            CrouchToggle = 327,
            Revive = 328,
            Parachute = 334,
            ParachuteObject = 335,
            TakeOffPedVariation = 336,
            CombatSeekCover = 339,
            CombatFlank = 341,
            Combat = 342,
            CombatMounted = 343,
            MoveCircle = 344,
            MoveCombatMounted = 345,
            Search = 346,
            SearchOnFoot = 347,
            SearchInAutomobile = 348,
            SearchInBoat = 349,
            SearchInHeli = 350,
            ThreatResponse = 351,
            Investigate = 352,
            StandGuardFSM = 353,
            Patrol = 354,
            ShootAtTarget = 355,
            SetAndGuardArea = 356,
            StandGuard = 357,
            Separate = 358,
            StayInCover = 359,
            VehicleCombat = 360,
            VehiclePersuit = 361,
            VehicleChase = 362,
            DraggingToSafety = 363,
            DraggedToSafety = 364,
            VariedAimPose = 365,
            MoveWithinAttackWindow = 366,
            MoveWithinDefensiveArea = 367,
            ShootOutTire = 368,
            ShellShocked = 369,
            BoatChase = 370,
            BoatCombat = 371,
            BoatStrafe = 372,
            HeliChase = 373,
            HeliCombat = 374,
            SubmarineCombat = 375,
            SubmarineChase = 376,
            PlaneChase = 377,
            TargetUnreachable = 378,
            TargetUnreachableInInterior = 379,
            TargetUnreachableInExterior = 380,
            StealthKill = 381,
            Writhe = 382,
            Advance = 383,
            Charge = 384,
            MoveToTacticalPoint = 385,
            ToHurtTransit = 386,
            AnimatedHitByExplosion = 387,
            NMRelax = 388,
            NMPose = 390,
            NMBrace = 391,
            NMBuoyancy = 392,
            NMInjuredOnGround = 393,
            NMShot = 394,
            NMHighFall = 395,
            NMBalance = 396,
            NMElectrocute = 397,
            NMPrototype = 398,
            NMExplosion = 399,
            NMOnFire = 400,
            NMScriptControl = 401,
            NMJumpRollFromRoadVehicle = 402,
            NMFlinch = 403,
            NMSit = 404,
            NMFallDown = 405,
            BlendFromNM = 406,
            NMControl = 407,
            NMDangle = 408,
            NMGenericAttach = 411,
            NMDrunk = 412,
            NMDraggingToSafety = 413,
            NMThroughWindscreen = 414,
            NMRiverRapids = 415,
            NMSimple = 416,
            RageRagdoll = 417,
            JumpVault = 420,
            Jump = 421,
            Fall = 422,
            ReactAimWeapon = 424,
            Chat = 425,
            MobilePhone = 426,
            ReactToDeadPed = 427,
            SearchForUnknownThreat = 429,
            Bomb = 431,
            Detonator = 432,
            AnimatedAttach = 434,
            CutScene = 440,
            ReactToExplosion = 441,
            ReactToImminentExplosion = 442,
            DiveToGround = 443,
            ReactAndFlee = 444,
            Sidestep = 445,
            CallPolice = 446,
            ReactInDirection = 447,
            ReactToBuddyShot = 448,
            VehicleGoToAutomobileNew = 453,
            VehicleGoToPlane = 454,
            VehicleGoToHelicopter = 455,
            VehicleGoToSubmarine = 456,
            VehicleGoToBoat = 457,
            VehicleGoToPointAutomobile = 458,
            VehicleGoToPointWithAvoidanceAutomobile = 459,
            VehiclePursue = 460,
            VehicleRam = 461,
            VehicleSpinOut = 462,
            VehicleApproach = 463,
            VehicleThreePointTurn = 464,
            VehicleDeadDriver = 465,
            VehicleCruiseNew = 466,
            VehicleCruiseBoat = 467,
            VehicleStop = 468,
            VehiclePullOver = 469,
            VehiclePassengerExit = 470,
            VehicleFlee = 471,
            VehicleFleeAirborne = 472,
            VehicleFleeBoat = 473,
            VehicleFollowRecording = 474,
            VehicleFollow = 475,
            VehicleBlock = 476,
            VehicleBlockCruiseInFront = 477,
            VehicleBlockBrakeInFront = 478,
            VehicleBlockBackAndForth = 479,
            VehicleCrash = 480,
            VehicleLand = 481,
            VehicleLandPlane = 482,
            VehicleHover = 483,
            VehicleAttack = 484,
            VehicleAttackTank = 485,
            VehicleCircle = 486,
            VehiclePoliceBehaviour = 487,
            VehiclePoliceBehaviourHelicopter = 488,
            VehiclePoliceBehaviourBoat = 489,
            VehicleEscort = 490,
            VehicleHeliProtect = 491,
            VehiclePlayerDriveAutomobile = 493,
            VehiclePlayerDriveBike = 494,
            VehiclePlayerDriveBoat = 495,
            VehiclePlayerDriveSubmarine = 496,
            VehiclePlayerDriveSubmarineCar = 497,
            VehiclePlayerDrivePlane = 498,
            VehiclePlayerDriveHeli = 499,
            VehiclePlayerDriveAutogyro = 500,
            VehiclePlayerDriveDiggerArm = 501,
            VehiclePlayerDriveTrain = 502,
            VehiclePlaneChase = 503,
            VehicleNoDriver = 504,
            VehicleAnimation = 505,
            VehicleConvertibleRoof = 506,
            VehicleParkNew = 507,
            VehicleFollowWaypointRecording = 508,
            VehicleGoToNavmesh = 509,
            VehicleReactToCopSiren = 510,
            VehicleGotoLongRange = 511,
            VehicleWait = 512,
            VehicleReverse = 513,
            VehicleBrake = 514,
            VehicleHandBrake = 515,
            VehicleTurn = 516,
            VehicleGoForward = 517,
            VehicleSwerve = 518,
            VehicleFlyDirection = 519,
            VehicleHeadonCollision = 520,
            VehicleBoostUseSteeringAngle = 521,
            VehicleShotTire = 522,
            VehicleBurnout = 523,
            VehicleRevEngine = 524,
            VehicleSurfaceInSubmarine = 525,
            VehiclePullAlongside = 526,
            VehicleTransformToSubmarine = 527,
            AnimatedFallback = 528
        }
    }
}
