///////////////////////////////////////////////////////////////////////////////
// HELPER METHODS
///////////////////////////////////////////////////////////////////////////////

public void ExecuteGitLink()
{
    RequireTool(GitLinkTool, () => {
        Information("Starting GitLink Execution...");

        var gitLinkSettings = new GitLinkSettings {
            SolutionFileName = string.Concat(BuildParameters.SourceDirectoryPath.GetDirectoryName(), "/", BuildParameters.SolutionFilePath.GetFilename())
        };


        if(ToolSettings.BuildPlatformTarget == PlatformTarget.x64)
        {
            gitLinkSettings.Platform = "x64";
        } 
        else if(ToolSettings.BuildPlatformTarget == PlatformTarget.x86)
        {
            gitLinkSettings.Platform = "x86";
        }

        GitLink(BuildParameters.RootDirectoryPath, gitLinkSettings);

        Information("GitLink Execution completed.");
    });
}