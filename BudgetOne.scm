/* JADE COMMAND FILE NAME H:\Ben\geek club\BudgetOne.jcf */
jadeVersionNumber "7.0.06";
schemaDefinition
BudgetOne subschemaOf RootSchema completeDefinition, patchVersioningEnabled = false;
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.493;
importedPackageDefinitions
constantDefinitions
localeDefinitions
	2057 "English (United Kingdom)" schemaDefaultLocale;
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.337;
libraryDefinitions
typeHeaders
	BudgetOne subclassOf RootSchemaApp transient, sharedTransientAllowed, transientAllowed, subclassSharedTransientAllowed, subclassTransientAllowed, number = 2435;
	ClassOne subclassOf Object transient, transientsOnly, number = 20494;
	GBudgetOne subclassOf RootSchemaGlobal transient, sharedTransientAllowed, transientAllowed, subclassSharedTransientAllowed, subclassTransientAllowed, number = 2436;
	SBudgetOne subclassOf RootSchemaSession transient, sharedTransientAllowed, transientAllowed, subclassSharedTransientAllowed, subclassTransientAllowed, number = 2437;
 
interfaceDefs
membershipDefinitions
 
typeDefinitions
	Object completeDefinition
	(
	)
	Application completeDefinition
	(
	)
	RootSchemaApp completeDefinition
	(
	)
	BudgetOne completeDefinition
	(
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.477;
	)
	ClassOne completeDefinition
	(
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:16.687;
	)
	Global completeDefinition
	(
	)
	RootSchemaGlobal completeDefinition
	(
	)
	GBudgetOne completeDefinition
	(
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.477;
	)
	WebSession completeDefinition
	(
	)
	RootSchemaSession completeDefinition
	(
		setModifiedTimeStamp "<unknown>" "6.1.00" 20031119 2003:12:01:13:54:02.270;
	)
	SBudgetOne completeDefinition
	(
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.493;
	)
 
inverseDefinitions
databaseDefinitions
BudgetOneDb
	(
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.493;
	databaseFileDefinitions
		"BudgetOne" number=78;
		setModifiedTimeStamp "4741" "7.0.06" 2015:07:03:16:19:01.493;
	defaultFileDefinition "BudgetOne";
	classMapDefinitions
		SBudgetOne in "_environ";
		BudgetOne in "_usergui";
		GBudgetOne in "BudgetOne";
		ClassOne in "BudgetOne";
	)
schemaViewDefinitions
exportedPackageDefinitions
typeSources
