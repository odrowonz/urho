﻿using System;
using System.Linq;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace Urho.iOS
{
	public static class UrhoEngine
	{
		[DllImport("mono-urho")]
		extern static void InitSdl(string resDir, string docDir);

		[DllImport("mono-urho", CallingConvention = CallingConvention.Cdecl)]
		extern static void SDL_SetMainReady();

		public static void Init<TApplication>() where TApplication : Application
		{
			Init(() => (Application) Activator.CreateInstance(typeof (TApplication), new Context()));
		}

		public static void Init(Func<Application> appCreator)
		{
			string docs = NSSearchPath.GetDirectories(NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.All, true).FirstOrDefault();
			string resources = NSBundle.MainBundle.ResourcePath;
			Init(appCreator, resources, docs);
		}

		public static void Init(Func<Application> appCreator, string resourcesDir, string docsDir)
		{
			Runtime.SetCustomRefcountedEventCallback(OnNativeDelete);
			Application.SetCustomApplicationCallback(Setup, Start, Stop);
			UrhoObject.SetCustomObjectCallback(ObjectCallback);
			InitSdl(resourcesDir, docsDir);
			SDL_SetMainReady();
			NSFileManager.DefaultManager.ChangeCurrentDirectory(resourcesDir);
			appCreator().Run();
		}

		//
		// Apply [MonoPInvokeCallback] to all native callbacks:
		//

		[MonoPInvokeCallback(typeof(Runtime.RefCountedEventCallback))]
		private static void OnNativeDelete(IntPtr ptr, Runtime.RefCountedEvent rcEvent)
		{
			Runtime.OnRefCountedEvent(ptr, rcEvent);
		}

		[MonoPInvokeCallback(typeof(Application.ActionIntPtr))]
		private static void Stop(IntPtr value)
		{
			Application.GetApp(value).Stop();
		}

		[MonoPInvokeCallback(typeof(Application.ActionIntPtr))]
		private static void Start(IntPtr value)
		{
			Application.GetApp(value).Start();
		}

		[MonoPInvokeCallback(typeof(Application.ActionIntPtr))]
		private static void Setup(IntPtr value)
		{
			Application.GetApp(value).Setup();
		}

		[MonoPInvokeCallback(typeof(ObjectCallbackSignature))]
		static void ObjectCallback(IntPtr data, int stringhash, IntPtr variantMap)
		{
			GCHandle gch = GCHandle.FromIntPtr(data);
			Action<IntPtr> a = (Action<IntPtr>)gch.Target;
			a(variantMap);
		}
	}
}