# Define the resource group and location
$resourceGroupName = "myResourceGroup"
$location = "East US"

# Create the resource group
New-AzResourceGroup -Name $resourceGroupName -Location $location

# Deploy the ARM template
New-AzResourceGroupDeployment -ResourceGroupName $resourceGroupName -TemplateFile "azuredeploy.json" -TemplateParameterFile "azuredeploy.parameters.json"
