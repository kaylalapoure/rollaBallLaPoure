//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Valve.VR
{
    using System;
    using UnityEngine;
    
    
    public partial class SteamVR_Actions
    {
        
        private static SteamVR_Action_Boolean p_actions_InteractUI;
        
        private static SteamVR_Action_Boolean p_actions_Teleport;
        
        private static SteamVR_Action_Boolean p_actions_GrabPinch;
        
        private static SteamVR_Action_Boolean p_actions_GrabGrip;
        
        private static SteamVR_Action_Pose p_actions_Pose;
        
        private static SteamVR_Action_Skeleton p_actions_SkeletonLeftHand;
        
        private static SteamVR_Action_Skeleton p_actions_SkeletonRightHand;
        
        private static SteamVR_Action_Single p_actions_Squeeze;
        
        private static SteamVR_Action_Boolean p_actions_HeadsetOnHead;
        
        private static SteamVR_Action_Boolean p_actions_SnapTurnLeft;
        
        private static SteamVR_Action_Boolean p_actions_SnapTurnRight;
        
        private static SteamVR_Action_Vibration p_actions_Haptic;
        
        private static SteamVR_Action_Vector2 p_platformer_Move;
        
        private static SteamVR_Action_Boolean p_platformer_Jump;
        
        private static SteamVR_Action_Vector2 p_buggy_Steering;
        
        private static SteamVR_Action_Single p_buggy_Throttle;
        
        private static SteamVR_Action_Boolean p_buggy_Brake;
        
        private static SteamVR_Action_Boolean p_buggy_Reset;
        
        private static SteamVR_Action_Pose p_mixedreality_ExternalCamera;
        
        public static SteamVR_Action_Boolean actions_InteractUI
        {
            get
            {
                return SteamVR_Actions.p_actions_InteractUI.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean actions_Teleport
        {
            get
            {
                return SteamVR_Actions.p_actions_Teleport.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean actions_GrabPinch
        {
            get
            {
                return SteamVR_Actions.p_actions_GrabPinch.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean actions_GrabGrip
        {
            get
            {
                return SteamVR_Actions.p_actions_GrabGrip.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose actions_Pose
        {
            get
            {
                return SteamVR_Actions.p_actions_Pose.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        public static SteamVR_Action_Skeleton actions_SkeletonLeftHand
        {
            get
            {
                return SteamVR_Actions.p_actions_SkeletonLeftHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Skeleton actions_SkeletonRightHand
        {
            get
            {
                return SteamVR_Actions.p_actions_SkeletonRightHand.GetCopy<SteamVR_Action_Skeleton>();
            }
        }
        
        public static SteamVR_Action_Single actions_Squeeze
        {
            get
            {
                return SteamVR_Actions.p_actions_Squeeze.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Boolean actions_HeadsetOnHead
        {
            get
            {
                return SteamVR_Actions.p_actions_HeadsetOnHead.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean actions_SnapTurnLeft
        {
            get
            {
                return SteamVR_Actions.p_actions_SnapTurnLeft.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean actions_SnapTurnRight
        {
            get
            {
                return SteamVR_Actions.p_actions_SnapTurnRight.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vibration actions_Haptic
        {
            get
            {
                return SteamVR_Actions.p_actions_Haptic.GetCopy<SteamVR_Action_Vibration>();
            }
        }
        
        public static SteamVR_Action_Vector2 platformer_Move
        {
            get
            {
                return SteamVR_Actions.p_platformer_Move.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Boolean platformer_Jump
        {
            get
            {
                return SteamVR_Actions.p_platformer_Jump.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Vector2 buggy_Steering
        {
            get
            {
                return SteamVR_Actions.p_buggy_Steering.GetCopy<SteamVR_Action_Vector2>();
            }
        }
        
        public static SteamVR_Action_Single buggy_Throttle
        {
            get
            {
                return SteamVR_Actions.p_buggy_Throttle.GetCopy<SteamVR_Action_Single>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Brake
        {
            get
            {
                return SteamVR_Actions.p_buggy_Brake.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Boolean buggy_Reset
        {
            get
            {
                return SteamVR_Actions.p_buggy_Reset.GetCopy<SteamVR_Action_Boolean>();
            }
        }
        
        public static SteamVR_Action_Pose mixedreality_ExternalCamera
        {
            get
            {
                return SteamVR_Actions.p_mixedreality_ExternalCamera.GetCopy<SteamVR_Action_Pose>();
            }
        }
        
        private static void InitializeActionArrays()
        {
            Valve.VR.SteamVR_Input.actions = new Valve.VR.SteamVR_Action[] {
                    SteamVR_Actions.actions_InteractUI,
                    SteamVR_Actions.actions_Teleport,
                    SteamVR_Actions.actions_GrabPinch,
                    SteamVR_Actions.actions_GrabGrip,
                    SteamVR_Actions.actions_Pose,
                    SteamVR_Actions.actions_SkeletonLeftHand,
                    SteamVR_Actions.actions_SkeletonRightHand,
                    SteamVR_Actions.actions_Squeeze,
                    SteamVR_Actions.actions_HeadsetOnHead,
                    SteamVR_Actions.actions_SnapTurnLeft,
                    SteamVR_Actions.actions_SnapTurnRight,
                    SteamVR_Actions.actions_Haptic,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.mixedreality_ExternalCamera};
            Valve.VR.SteamVR_Input.actionsIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.actions_InteractUI,
                    SteamVR_Actions.actions_Teleport,
                    SteamVR_Actions.actions_GrabPinch,
                    SteamVR_Actions.actions_GrabGrip,
                    SteamVR_Actions.actions_Pose,
                    SteamVR_Actions.actions_SkeletonLeftHand,
                    SteamVR_Actions.actions_SkeletonRightHand,
                    SteamVR_Actions.actions_Squeeze,
                    SteamVR_Actions.actions_HeadsetOnHead,
                    SteamVR_Actions.actions_SnapTurnLeft,
                    SteamVR_Actions.actions_SnapTurnRight,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset,
                    SteamVR_Actions.mixedreality_ExternalCamera};
            Valve.VR.SteamVR_Input.actionsOut = new Valve.VR.ISteamVR_Action_Out[] {
                    SteamVR_Actions.actions_Haptic};
            Valve.VR.SteamVR_Input.actionsVibration = new Valve.VR.SteamVR_Action_Vibration[] {
                    SteamVR_Actions.actions_Haptic};
            Valve.VR.SteamVR_Input.actionsPose = new Valve.VR.SteamVR_Action_Pose[] {
                    SteamVR_Actions.actions_Pose,
                    SteamVR_Actions.mixedreality_ExternalCamera};
            Valve.VR.SteamVR_Input.actionsBoolean = new Valve.VR.SteamVR_Action_Boolean[] {
                    SteamVR_Actions.actions_InteractUI,
                    SteamVR_Actions.actions_Teleport,
                    SteamVR_Actions.actions_GrabPinch,
                    SteamVR_Actions.actions_GrabGrip,
                    SteamVR_Actions.actions_HeadsetOnHead,
                    SteamVR_Actions.actions_SnapTurnLeft,
                    SteamVR_Actions.actions_SnapTurnRight,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset};
            Valve.VR.SteamVR_Input.actionsSingle = new Valve.VR.SteamVR_Action_Single[] {
                    SteamVR_Actions.actions_Squeeze,
                    SteamVR_Actions.buggy_Throttle};
            Valve.VR.SteamVR_Input.actionsVector2 = new Valve.VR.SteamVR_Action_Vector2[] {
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.buggy_Steering};
            Valve.VR.SteamVR_Input.actionsVector3 = new Valve.VR.SteamVR_Action_Vector3[0];
            Valve.VR.SteamVR_Input.actionsSkeleton = new Valve.VR.SteamVR_Action_Skeleton[] {
                    SteamVR_Actions.actions_SkeletonLeftHand,
                    SteamVR_Actions.actions_SkeletonRightHand};
            Valve.VR.SteamVR_Input.actionsNonPoseNonSkeletonIn = new Valve.VR.ISteamVR_Action_In[] {
                    SteamVR_Actions.actions_InteractUI,
                    SteamVR_Actions.actions_Teleport,
                    SteamVR_Actions.actions_GrabPinch,
                    SteamVR_Actions.actions_GrabGrip,
                    SteamVR_Actions.actions_Squeeze,
                    SteamVR_Actions.actions_HeadsetOnHead,
                    SteamVR_Actions.actions_SnapTurnLeft,
                    SteamVR_Actions.actions_SnapTurnRight,
                    SteamVR_Actions.platformer_Move,
                    SteamVR_Actions.platformer_Jump,
                    SteamVR_Actions.buggy_Steering,
                    SteamVR_Actions.buggy_Throttle,
                    SteamVR_Actions.buggy_Brake,
                    SteamVR_Actions.buggy_Reset};
        }
        
        private static void PreInitActions()
        {
            SteamVR_Actions.p_actions_InteractUI = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/InteractUI")));
            SteamVR_Actions.p_actions_Teleport = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/Teleport")));
            SteamVR_Actions.p_actions_GrabPinch = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/GrabPinch")));
            SteamVR_Actions.p_actions_GrabGrip = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/GrabGrip")));
            SteamVR_Actions.p_actions_Pose = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/actions/in/Pose")));
            SteamVR_Actions.p_actions_SkeletonLeftHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/actions/in/SkeletonLeftHand")));
            SteamVR_Actions.p_actions_SkeletonRightHand = ((SteamVR_Action_Skeleton)(SteamVR_Action.Create<SteamVR_Action_Skeleton>("/actions/actions/in/SkeletonRightHand")));
            SteamVR_Actions.p_actions_Squeeze = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/actions/in/Squeeze")));
            SteamVR_Actions.p_actions_HeadsetOnHead = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/HeadsetOnHead")));
            SteamVR_Actions.p_actions_SnapTurnLeft = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/SnapTurnLeft")));
            SteamVR_Actions.p_actions_SnapTurnRight = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/actions/in/SnapTurnRight")));
            SteamVR_Actions.p_actions_Haptic = ((SteamVR_Action_Vibration)(SteamVR_Action.Create<SteamVR_Action_Vibration>("/actions/actions/out/Haptic")));
            SteamVR_Actions.p_platformer_Move = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/platformer/in/Move")));
            SteamVR_Actions.p_platformer_Jump = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/platformer/in/Jump")));
            SteamVR_Actions.p_buggy_Steering = ((SteamVR_Action_Vector2)(SteamVR_Action.Create<SteamVR_Action_Vector2>("/actions/buggy/in/Steering")));
            SteamVR_Actions.p_buggy_Throttle = ((SteamVR_Action_Single)(SteamVR_Action.Create<SteamVR_Action_Single>("/actions/buggy/in/Throttle")));
            SteamVR_Actions.p_buggy_Brake = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Brake")));
            SteamVR_Actions.p_buggy_Reset = ((SteamVR_Action_Boolean)(SteamVR_Action.Create<SteamVR_Action_Boolean>("/actions/buggy/in/Reset")));
            SteamVR_Actions.p_mixedreality_ExternalCamera = ((SteamVR_Action_Pose)(SteamVR_Action.Create<SteamVR_Action_Pose>("/actions/mixedreality/in/ExternalCamera")));
        }
    }
}