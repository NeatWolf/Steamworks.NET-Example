// This file is automatically generated!

using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamController {
		//
		// Native controller support API
		//
		// Must call init and shutdown when starting/ending use of the interface
		public static bool Init(string pchAbsolutePathToControllerConfigVDF) {
			return NativeMethods.ISteamController_Init(new InteropHelp.UTF8String(pchAbsolutePathToControllerConfigVDF));
		}

		public static bool Shutdown() {
			return NativeMethods.ISteamController_Shutdown();
		}

		// Pump callback/callresult events, SteamAPI_RunCallbacks will do this for you,
		// normally never need to call directly.
		public static void RunFrame() {
			NativeMethods.ISteamController_RunFrame();
		}

		// Get the state of the specified controller, returns false if that controller is not connected
		public static bool GetControllerState(uint unControllerIndex, out SteamControllerState_t pState) {
			return NativeMethods.ISteamController_GetControllerState(unControllerIndex, out pState);
		}

		// Trigger a haptic pulse on the controller
		public static void TriggerHapticPulse(uint unControllerIndex, ESteamControllerPad eTargetPad, ushort usDurationMicroSec) {
			NativeMethods.ISteamController_TriggerHapticPulse(unControllerIndex, eTargetPad, usDurationMicroSec);
		}

		// Set the override mode which is used to choose to use different base/legacy bindings from your config file
		public static void SetOverrideMode(string pchMode) {
			NativeMethods.ISteamController_SetOverrideMode(new InteropHelp.UTF8String(pchMode));
		}
	}
}