var target = Argument("target", "Build");


Task("Clean")
.Does(() =>
{
// Clean directories.
CleanDirectory("./output");
CleanDirectory("./output/bin");
CleanDirectories("./src/**/bin/");
});

Task("Default")
  .IsDependentOn("Clean");

Task("Build")
  .Does(() =>
{
  MSBuild("./src/DevOpsAssignment.sln");
});

Task("Run-Unit-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
    MSTest("./src/DevOpsAssignment.Tests/bin/Debug/DevOpsAssignment.Tests.dll");
});
Task("Run-Integration-Tests")
    .IsDependentOn("Build")
    .Does(() =>
{
    MSTest("./src/DevOpsAssignment_IntegrationTests/bin/Debug/DevOpsAssignment_IntegrationTests.dll");
});
Task("CopyFiles")
.IsDependentOn("Run-Unit-Tests")
.Does(() =>
{
var path = @"c:\temp\DevOpsTest";
var files = GetFiles(path + "/**/*.dll")
+ GetFiles(path + "/**/*.txt");
// Copy all exe and dll files to the output directory.
CopyFiles(files, "./output/bin");
});
Task("Package")
.IsDependentOn("Run-Unit-Tests")
.Does(() =>
{
// Zip all files in the bin directory.
Zip("./output/bin", "./output/build.zip");
});

RunTarget(target);

