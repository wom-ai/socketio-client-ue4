// Copyright 2018-current Getnamo. All Rights Reserved


using System.IO;
using UnrealBuildTool;

namespace UnrealBuildTool.Rules
{
	public class SocketIOLib : ModuleRules
	{
		private string ThirdPartyPath
        {
            get { return Path.GetFullPath(Path.Combine(ModuleDirectory, "../ThirdParty/")); }
        }

	    public SocketIOLib(ReadOnlyTargetRules Target) : base(Target)
	    {
			PCHUsage = PCHUsageMode.NoSharedPCHs;
			bUseRTTI = true;
			bEnableExceptions = true;

			PublicIncludePaths.AddRange(
	            new string[] {
					Path.Combine(ModuleDirectory, "Public"),
	            }
	            );


	        PrivateIncludePaths.AddRange(
	            new string[] {
					Path.Combine(ModuleDirectory, "Private"),
					Path.Combine(ModuleDirectory, "Private/internal"),
					Path.Combine(ThirdPartyPath, "websocketpp"),
					Path.Combine(ThirdPartyPath, "asio"),
					Path.Combine(ThirdPartyPath, "rapidjson"),
	            }
	            );


	        PublicDependencyModuleNames.AddRange(
	            new string[]
	            {
	            "Core",
	            }
	            );


	        PrivateDependencyModuleNames.AddRange(
	            new string[]
	            {
	            "CoreUObject",
	            "Engine",
	            }
	            );


	        DynamicallyLoadedModuleNames.AddRange(
	            new string[]
	            {
	            }
	            );
	    }
	}
}
