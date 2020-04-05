# Paths
$packFolder = (Get-Item -Path "./" -Verbose).FullName
$rootFolder = Join-Path $packFolder "../"

# List of solutions，解决方案的文件夹
$solutions = (
    ""
)

# List of projects
$projects = (

    # aspnet-core
    "src/Abp.Module.Inventory.Application",
    "src/Abp.Module.Inventory.Application.Contracts",
    "src/Abp.Module.Inventory.Domain",
    "src/Abp.Module.Inventory.Domain.Shared",
    "src/Abp.Module.Inventory.EntityFrameworkCore",
    "src/Abp.Module.Inventory.HttpApi",
    "src/Abp.Module.Inventory.HttpApi.Client",
    "src/Abp.Module.Inventory.MongoDB"
)