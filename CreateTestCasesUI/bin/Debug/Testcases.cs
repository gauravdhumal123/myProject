[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_001 : To verify that Software shall have a option to Configure DICOM server in Settings -> Server -> DICOM")]
[Owner("Gaurav Dhumal")]
public void TC_1136549()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141188 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141189 :: 1. Press Menu > Settings button on Home screen with DICOM package enabled on the SDC4K. 1.Setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141190 :: 2. Press Server -> DICOM button to navigate to DICOM Screen. 2. DICOM screen should be displayed with three tabs Server/Client, Required Fields and Settings.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141191 :: 3. Select Server/Client tab, observe the Connection Name dropdown displayed on the screen. 3. Connection Name dropdown should be displayed on the Server settings screen to configure a DICOM Server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that Software shall have a option to Configure DICOM server in Settings -> Server -> DICOM<br>"
			+"Actual : To verify that Software shall have a option to Configure DICOM server in Settings -> Server -> DICOM");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_002 : To verify that software shall allow to Add and Delete DICOM connections.")]
[Owner("Gaurav Dhumal")]
public void TC_1136582()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141192 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141193 :: Press Menu > Settings button on Home screen with DICOM package enabled on the SDC4K. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141194 :: Press Server -> DICOM button to navigate to DICOM Screen. DICOM screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141195 :: Enter a valid DICOM Server Name in the connection name dropdown and click on the Add button. Specified DICOM connection name should be successfully added.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141196 :: Select the same server name from connection name dropdown and click on the Delete button A pop up window will appear displaying Do you want to delete this item with Yes and No button.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141197 :: Click on the Yes button. DICOM server Connection should be deleted from the connection name dropdown.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall allow to Add and Delete DICOM connections.<br>"
			+"Actual : To verify that software shall allow to Add and Delete DICOM connections.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_003 : To verify that software shall allow the operator to add more than one PACS connection in the DICOM server.")]
[Owner("Gaurav Dhumal")]
public void TC_1136578()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141198 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141199 :: 1. Press Menu >Settings button on Home screen with DICOM package enabled on the SDC4K. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141200 :: 2. Press Server -> DICOM button to navigate to DICOM Screen. 2. DICOM screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141201 :: 3. Enter a valid DICOM Server Name in the connection name dropdown and click on the Add button. 3. Specified DICOM connection name should be successfully added.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141202 :: 4. Again select the blank row from Connection Name dropdown. Enter a different but valid DICOM Server Name in the connection name dropdown and click on the Add button. 4. Another DICOM Connection should also be added in the DICOM Connection name dropdown.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall allow the operator to add more than one PACS connection in the DICOM server.<br>"
			+"Actual : To verify that software shall allow the operator to add more than one PACS connection in the DICOM server.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_004 : To verify that software shall have 'asterisk' and 'space' for Modality Wild Card option in Server section present in Server/Client screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1136589()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141203 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141204 :: 1. Press Menu >Settings button on Home screen with DICOM package enabled on the SDC4K. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141205 :: 2. Press Server -> DICOM button to navigate to DICOM Screen. 2. DICOM screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141206 :: 3. Select the blank context from Connection Name dropdown. 3. Connection Name dropdown from DICOM Server/Client settings should be selected to blank.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141207 :: 4. Add a new connection name 4. New DICOM connection added and the modality wildcard option is enabled");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141208 :: 5. Expand the Modality Wildcard dropdown and Scroll through the options. 5. Two options for Modality Wildcards should be displayed Space and Asterisk .");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall have 'asterisk' and 'space' for Modality Wild Card option in Server section present in Server/Client screen.<br>"
			+"Actual : To verify that software shall have 'asterisk' and 'space' for Modality Wild Card option in Server section present in Server/Client screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_005 : To verify that software shall set the Modality Wildcard as asterisk by default whenever a new connection is created.")]
[Owner("Gaurav Dhumal")]
public void TC_1136586()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141209 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141210 :: 1. Press Menu >Settings button on Home screen with DICOM package enabled on the SDC4K. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141211 :: 2. Press Server -> DICOM button to navigate to DICOM Screen. 2. DICOM screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141212 :: 3. Select the blank context from Connection Name dropdown. 3. Connection Name dropdown from DICOM Server/Client settings should be selected to blank.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141213 :: 4. Add a new connection name 4. New DICOM connection added and the modality wildcard option is enabled");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141214 :: 5. Observe the Modality Wildcard dropdown and check the default option. 5. Default option for Modality Wildcards should be Asterix *.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall set the Modality Wildcard as asterisk by default whenever a new connection is created.<br>"
			+"Actual : To verify that software shall set the Modality Wildcard as asterisk by default whenever a new connection is created.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_006 : To verify that software shall allow to change network adapter from IPv4 to IPv6 present in server settings.")]
[Owner("Gaurav Dhumal")]
public void TC_1136570()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141215 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141216 :: Click on Menu button. Menu panel should be opened.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141218 :: Navigate to Settings > Server > DICOM settings > Server/Client settings. The DICOM server/client setting should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141219 :: Select the blank context from Connection Name dropdown and observe the adapter settings present next to Modality Wildcard dropdown. Connection Name dropdown from DICOM Server/Client settings should be selected to blank. IPv4 adapter setting should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141220 :: Change the adapter setting from IPv4 to IPv6. The adapter setting should successfully changed to IPv6.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141221 :: Add a new connection name New DICOM connection added and the modality wildcard option is enabled");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141222 :: Observe the adapter settings present next to Modality Wildcard dropdown. IPv4 setting should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141223 :: Change the adapter setting from IPv4 to IPv6. The adapter setting should successfully changed to IPv6.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall allow to change network adapter from IPv4 to IPv6 present in server settings.<br>"
			+"Actual : To verify that software shall allow to change network adapter from IPv4 to IPv6 present in server settings.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_007 : To verify that Software shall allow user to configure Store,MWL,Q/R,SC fields.")]
[Owner("Gaurav Dhumal")]
public void TC_1136567()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141224 :: Pre-Condition :
1.SDC4K Application should be running.
2.Dicom package should be activated. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141225 :: 1. Press Menu > Settings button from SDC4K Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141226 :: 2. Press Server -> DICOM button to navigate to DICOM server/client setting Screen. 2. DICOM server/client setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141227 :: 3. Enter a valid DICOM Server Name in the connection name dropdown and click on the Add button. 3. Specified DICOM connection name should be successfully added.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141228 :: 4. Observe the fields that are required to be configure Store,MWL,Q/R,SC servers. 4. AE Title, IP Address and Port number fields shall be required to configure Store,MWL,Q/R,SC server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141229 :: 5. Now Enter the valid IP Address, AE Title and Port number fields for Store,MWL,Q/R, SC server. 5. The user should be allowed to configure IP Address, AE Title and Port number fields for Store,MWL,Q/R, SC server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that Software shall allow user to configure Store,MWL,Q/R,SC fields.<br>"
			+"Actual : To verify that Software shall allow user to configure Store,MWL,Q/R,SC fields.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_008 : To verify that software shall require AE Title, IP Address and Port Number to ECHO the DICOM server.")]
[Owner("Gaurav Dhumal")]
public void TC_1136575()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141230 :: Pre-Condition : Application should be running. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141231 :: 1. Press Menu > Settings button on Home screen with DICOM package enabled on the SDC4K. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141232 :: 2. Press Server -> DICOM button to navigate to DICOM server/client setting Screen. 2. DICOM server/client setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141233 :: 3. Enter a valid DICOM Server Name in the connection name dropdown and click on the Add button. Also add the required DICOM Client settings. 3. Specified DICOM connection name should be successfully added. DICOM Client settings should also be added.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141234 :: 4. Do not enter the IP Address, AE Title and Port number for Store servers and click on the Echo button. 4. An appropriate Error message should be displayed while doing ECHO operation w/o IP Address, AE Title and Port number fields for Store server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141235 :: 5. Now Enter the valid IP Address, AE Title and Port number fields for Store server and again click on ECHO button. 5. The Echo operation should be successful now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141236 :: 6. Now enter the invalid IP Address, AE Title and Port number fields for Store server and again click on ECHO button. 6. The Echo operation should be Failed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141237 :: 7. Repeat the above 3 steps for MWL,Q/R,SC servers as well. 7. The same behavior should occur for remaining three servers as well i.e. MWL,Q/R,SC servers.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall require AE Title, IP Address and Port Number to ECHO the DICOM server.<br>"
			+"Actual : To verify that software shall require AE Title, IP Address and Port Number to ECHO the DICOM server.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_009 : To verify that software shall allow an operator to ping the PACs server only when DICOM client is configured otherwise shall display an error message saying that Please configure the DICOM client before ping.")]
[Owner("Gaurav Dhumal")]
public void TC_1136574()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141238 :: Preconditions:
a. SDC4K machine should be connected to network.
b. DICOM package should be installed.
c. SDC4K application should be installed and running.
d. SDC4K machine should be connected to IPv4 configured LAN. Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141239 :: 1. Launch the SDC4K Software application. 1. Home Screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141240 :: 2. Verify the availability of Menu button at the bottom right of the global task bar. 2. SDC4K software system should have Menu button at the bottom right of the global task bar.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141241 :: 3. Navigate to Menu > Settings > Server > DICOM tab and verify that DICOM settings screen should get displayed. 3. DICOM settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141242 :: 4. From the DICOM settings screen verify that there should be two sections present for Server and Client configuration. 4. The Server and Client configuration section should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141243 :: 5. Add a new PACS connection and configure the server settings without configuring client settings. Save and Echo the IP settings. 5. Please configure the DICOM client before ping message should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141244 :: 6. Configure the Client settings entering valid AE Title, Modality and Port, verify that echoing the settings should be successful by clicking the Echo button. 6. Echo should be successful and the operator should be able to ping the settings successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141245 :: 7. Repeat above test steps (SDC4K machine should be connected to IPv4 configured wireless network, and disconnected from LAN) 7. Expected results should be same.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall allow an operator to ping the PACs server only when DICOM client is configured otherwise shall display an error message saying that Please configure the DICOM client before ping.<br>"
			+"Actual : To verify that software shall allow an operator to ping the PACs server only when DICOM client is configured otherwise shall display an error message saying that Please configure the DICOM client before ping.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_010 : To verify that software shall have Port number and IP Address field in Client Section.")]
[Owner("Gaurav Dhumal")]
public void TC_1136604()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141246 :: Preconditions:
1.SDC4K should be up and running.
2.Dicom Package should be activated. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141247 :: 1.Click on Menu button. Menu panel should be opened.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141248 :: 2. Navigate to Settings > Server > DICOM settings > Server/Client settings and verify IP address and Port fields should be available under the client section. 2. IP address and Port fields should be available under the client section.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall have Port number and IP Address field in Client Section.<br>"
			+"Actual : To verify that software shall have Port number and IP Address field in Client Section.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_011 : To verify that software display IP address retrieved from IP settings of the connected LAN network adapter.")]
[Owner("Gaurav Dhumal")]
public void TC_1136602()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141249 :: Preconditions:
a. SDC4K should be up and running.
b. Make sure SDC4K is connected to LAN. Network connectivity should be configured.
c. Dicom package should be installed. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141250 :: 1. Navigate to Menu > Settings screen and select network settings. 1. Network Setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141251 :: 2. On the Adapter tab, select Public from the dropdown list and note the values in IP address field. 2. IP address of Public connection should be displayed and noted successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141252 :: 3. Navigate to Server -> DICOM settings -> Client settings and verify the value of IP address reflected. 3. The DICOM setting should be successfully selected and IP address fields should reflect the same value noted in adapter screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software display IP address retrieved from IP settings of the connected LAN network adapter.<br>"
			+"Actual : To verify that software display IP address retrieved from IP settings of the connected LAN network adapter.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_012 : To verify that software display IP address retrieved from IP settings of the connected Wi Fi network adapter.")]
[Owner("Gaurav Dhumal")]
public void TC_1136606()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141253 :: Preconditions:
a. SDC4K should be up and running.
b. Make sure SDC4K is connected to Wi Fi and not LAN. Network connectivity should be configured. c. Dicom Package should be installed. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141255 :: 1. Navigate to Menu > Settings screen and select network settings. 1. Network Setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141256 :: 2. On the Adapter tab,select Wireless connection from the dropdown list and note the values in IP address field. 2. IP address of Wireless connection should be displayed and noted successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141257 :: 3. Navigate to Server -> DICOM settings -> Client settings and verify the value of IP address reflected. 3. The DICOM setting should be successfully selected and IP address fields should reflect the same value noted in adapter screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software display IP address retrieved from IP settings of the connected Wi Fi network adapter.<br>"
			+"Actual : To verify that software display IP address retrieved from IP settings of the connected Wi Fi network adapter.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_013 : To verify that software prefer LAN IP address retrieved from IP settings over Wi-Fi.")]
[Owner("Gaurav Dhumal")]
public void TC_1136605()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141258 :: Preconditions:
a. SDC4K should be up and running.
b. SDC4K should be connected to both LAN and Wi-Fi network, configured for IPv4.
c. Dicom Package should be activated. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141259 :: 1. Navigate to Menu > Settings screen and select network setting tab. 1. Network setting option should be selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141260 :: 2. Select Adapter tab from network settings screen, select Public from the dropdown list and note the values in the IP address field. Repeat the same for Wireless connection. 2. IP address of Public and Wireless connection should be noted successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141261 :: 3. Navigate to Server -> DICOM -> Server/Client settings 3. DICOM Server/Client settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141262 :: 4. Verify the value reflected in the IP address field under the client section. 4. The value reflected in the IP address field under the Client section should be of LAN network in Network Adapter Settings screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software prefer LAN IP address retrieved from IP settings over Wi-Fi.<br>"
			+"Actual : To verify that software prefer LAN IP address retrieved from IP settings over Wi-Fi.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_014 : To verify that software shall allow user to select 'Modality' from Client section present in DICOM Server/Client screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1136595()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141263 :: Preconditions: SDC4K should be up and running. Dicom package should be installed. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141264 :: 1. Login to SDC4K and Navigate to Setting screen. 1. Setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141265 :: 2. Navigate to Settings > Server > DICOM settings > Server/Client settings and observe the Modality dropdown field. 2. The Modality dropdown field should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141266 :: Click on the Modality dropdown field and try to select any value from it. User should be able to select any value from the modality dropdown field.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall allow user to select 'Modality' from Client section present in DICOM Server/Client screen.<br>"
			+"Actual : To verify that software shall allow user to select 'Modality' from Client section present in DICOM Server/Client screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_015 : To verify that software shall have 'ES', 'XC' and 'SC' for Modality option under dicom client configuration.")]
[Owner("Gaurav Dhumal")]
public void TC_1136591()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141267 :: Preconditions: SDC4K should be up and running. Dicom package should be installed. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141268 :: 1. Login to SDC4K and Navigate to Menu > Settings screen. 1. Setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141269 :: 2. Navigate to Settings > Server > DICOM settings > Server/Client settings and observe the Modality fields. 2. The DICOM setting should be successfully selected and Modality dropdown field should be available.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141270 :: 3. Observe the various options available in the Modality dropdown. 3. ES, XC and SC options should be available in the Modality dropdown under DICOM client configuration.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall have 'ES', 'XC' and 'SC' for Modality option under dicom client configuration.<br>"
			+"Actual : To verify that software shall have 'ES', 'XC' and 'SC' for Modality option under dicom client configuration.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_016 : To verify that software shall have a Save button in Server/Client screen which should allow user to save all the DICOM connection settings.")]
[Owner("Gaurav Dhumal")]
public void TC_1136600()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141271 :: Preconditions:
1.SDC4K should be up and running
2.Dicom package should be installed. Pre-Conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141272 :: 1. Login to SDC4K and Navigate to Menu > Settings screen. 1. Setting screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141273 :: 2. Navigate to Settings > Server > DICOM settings > Server/Client settings and observe the Save button. 2. The DICOM setting should be successfully selected and Save button should be available.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141274 :: 3. Configure a valid DICOM Server and the valid DICOM Client settings. 3. User should be allowed to configure the DICOM Client and server settings.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141275 :: 4. Click on the Save button. 4. All settings should be saved successfully and the confirmation message should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141276 :: Restart the SDC4K machine and verify the Dicom setting are saved. The Dicom settings should persist after the reboot.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall have a Save button in Server/Client screen which should allow user to save all the DICOM connection settings.<br>"
			+"Actual : To verify that software shall have a Save button in Server/Client screen which should allow user to save all the DICOM connection settings.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_017 : To verify that software shall have a tab in DICOM to configure Required Fields: Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID, Patient Name and Patient ID.")]
[Owner("Gaurav Dhumal")]
public void TC_1136598()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141277 :: Pre-requisite:
a. Application should be installed and running
b. DICOM package should be installed
c. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141278 :: 1. Launch the application 1. The application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141279 :: 2. Navigate to Menu > Settings > Server > DICOM tab and verify that DICOM settings screen should get displayed 2. DICOM settings screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141280 :: 3. Select the DICOM Server from the list of Connection Name drop down field 3. The DICOM server should get selected successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141281 :: 4. Navigate to the Required fields tab and observe the fields displayed. 4. Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID, Patient Name and Patient ID field should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall have a tab in DICOM to configure Required Fields: Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID, Patient Name and Patient ID.<br>"
			+"Actual : To verify that software shall have a tab in DICOM to configure Required Fields: Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID, Patient Name and Patient ID.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_018 : To verify that software shall allow user to check/uncheck Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID.")]
[Owner("Gaurav Dhumal")]
public void TC_1136622()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141282 :: Pre-requisite:
a. Application should be installed and running
b. DICOM package should be installed
c. A valid DICOM servers should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141283 :: 1. Launch the SDC4K application 1. The application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141284 :: 2. Navigate to Menu > Settings > Server > DICOM tab and verify that DICOM server/client setting screen should get displayed 2. DICOM server/client setting screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141285 :: 3. Select the DICOM Server from the list of Connection Name drop down field 3. The DICOM server should get selected successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141286 :: 4. Navigate to the Required fields tab and Try to check/uncheck Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID fields. 4. The operator should be able to check/uncheck Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID fields.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall allow user to check/uncheck Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID.<br>"
			+"Actual : To verify that software shall allow user to check/uncheck Gender, Birth Date, Surgeon, Procedure, Referrer, Accession No., Department, Facility, Station ID.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_019 : To verify that software shall not allow Patient Name and Patient ID field to be unchecked as these are mandatory fields.")]
[Owner("Gaurav Dhumal")]
public void TC_1136619()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141287 :: Pre-requisite:
a. Application should be installed and running
b. DICOM package should be installed
c. A valid DICOM servers should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141288 :: 1. Launch the SDC4K application 1. The application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141289 :: 2. Navigate to Menu > Settings > Server > DICOM tab and verify that DICOM settings screen should get displayed 2. DICOM settings screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141290 :: 3. Select the DICOM Server from the list of Connection Name drop down field 3. The DICOM server should get selected successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141292 :: 4. Navigate to the Required fields tab and verify the Patient Name and the Patient Id fields. 4.The Patient Name and the Patient Id fields should be selected by default.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141293 :: 5. Try to uncheck Patient Name and Patient Id fields. 5.The operator should not be able to uncheck the Patient Name and the Patient Id fields");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall not allow Patient Name and Patient ID field to be unchecked as these are mandatory fields.<br>"
			+"Actual : To verify that software shall not allow Patient Name and Patient ID field to be unchecked as these are mandatory fields.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_020 : To verify that DICOM Settings specifying Retrieve Method, Retrieve Level, Study Instance UID, Storage Commit Assc., DICOM Video and Storage Commit shall be specific to the selected DICOM Server Connection.")]
[Owner("Gaurav Dhumal")]
public void TC_1136626()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141294 :: Pre-requisite:
a. Application should be installed and running
b. DICOM package should be installed
c. Two valid DICOM connections should be configured on the application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141295 :: 1. Launch the application. 1. The application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141296 :: 2. Navigate to Menu > Settings > Server > DICOM tab and verify that DICOM Server/Client screen should get displayed 2. DICOM Server/Client screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141297 :: 3. Select the first DICOM Server from the list of Connection Name drop down field 3. The first DICOM server should get selected successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141298 :: 4. Navigate to the Settings tab and observe the settings displayed. 4. The settings corresponding to the first server should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141299 :: 5. Select the second DICOM Server from the Server/client screen and navigate back to settings screen. Observe the settings displayed. 5. The settings corresponding to the second server should be displayed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that DICOM Settings specifying Retrieve Method, Retrieve Level, Study Instance UID, Storage Commit Assc., DICOM Video and Storage Commit shall be specific to the selected DICOM Server Connection.<br>"
			+"Actual : To verify that DICOM Settings specifying Retrieve Method, Retrieve Level, Study Instance UID, Storage Commit Assc., DICOM Video and Storage Commit shall be specific to the selected DICOM Server Connection.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_021 : To verify that Default value for Storage Commit shall be off, Storage Commit association shall be Two Way with control being disabled, Retrieve Method shall be C-Move, Retrieve Level shall be Study, Study Instance UID shall be SCU, DICOM Video shall be OFF.")]
[Owner("Gaurav Dhumal")]
public void TC_1136624()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141300 :: Precondition:
a. SDC4K machine should be connected to network.
b. DICOM package should be installed
c. SDC4K application should be installed and running Precondition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141301 :: Navigate to Menu > Settings > Server > DICOM > Settings tab and verify that DICOM settings screen should get displayed. DICOM settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141302 :: From the DICOM settings screen verify that that following setting options should be present in the Settings Tab :
-Retrieve Method
-Retrieve Level
-Study Instance UID
-Storage Commit Assoc
-Storage Commit
-DICOM Video All the setting option listed should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141303 :: Verify that Default value for Storage Commit, Storage Commit Association, Retrieve Method, Retrieve Level, Study Instance UID and DICOM Video. Default values for Storage Commit shall be OFF, Storage Commit Association shall be Two-Way with control being disabled, Retrieve Method shall be C-Move, Retrieve Level shall be Study, Study Instance UID shall be SCU and DICOM Video shall be OFF.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141304 :: Add a valid DICOM connection name and verify the value of Storage Commit Association in the Settings Tab Default value of Storage commit asscociation should be Two-Way in the Settings Tab.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that Default value for Storage Commit shall be off, Storage Commit association shall be Two Way with control being disabled, Retrieve Method shall be C-Move, Retrieve Level shall be Study, Study Instance UID shall be SCU, DICOM Video shall be OFF.<br>"
			+"Actual : To verify that Default value for Storage Commit shall be off, Storage Commit association shall be Two Way with control being disabled, Retrieve Method shall be C-Move, Retrieve Level shall be Study, Study Instance UID shall be SCU, DICOM Video shall be OFF.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_022 : To verify that Software shall display Retrieve Method options (C-Move/C-Get) under the server DICOM Settings Screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1136610()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141305 :: Pre-Condition :
1.SDC4K Application should be running.
2.DICOM package should be activated and configured. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141306 :: 1. Press Menu > Settings button on Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141307 :: 2. Navigate to Server -> DICOM -> Settings tab. 2. DICOM Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141308 :: 3. Observe the existence of Retrieve Method button. 3. The Retrieve Method button should be available.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141309 :: 4. Change the Retrieve Method toggle button to C-Get. 4. Retrieve Method should be successfully changed to C-Get.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141310 :: 5. Change the Retrieve Method toggle button to C-Move. 5. Retrieve Method should be successfully changed to C-Move.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that Software shall display Retrieve Method options (C-Move/C-Get) under the server DICOM Settings Screen.<br>"
			+"Actual : To verify that Software shall display Retrieve Method options (C-Move/C-Get) under the server DICOM Settings Screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_023 : To verify that Software shall display Retrieve Level options (Patient/Study) under the server DICOM Settings Screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1136608()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141311 :: Pre-Condition : Application should be running. Dicom package should be installed.
DICOM server client settings should be configured in Menu>Settings>Server>DICOM Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141312 :: 1. Press Menu > Settings button on Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141313 :: 2. Navigate to Server -> DICOM Tab and then to Settings button. 2. DICOM Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141314 :: 3. Observe the existence of Retrieve Level button. 3. The Retrieve Level button should be available.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141315 :: 4. Change the Retrieve Level toggle button to Study. 4. Retrieve Level should be successfully changed to Study.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141316 :: 5. Change the Retrieve Level toggle button to Patient 5. Retrieve Level should be successfully changed to Patient.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that Software shall display Retrieve Level options (Patient/Study) under the server DICOM Settings Screen.<br>"
			+"Actual : To verify that Software shall display Retrieve Level options (Patient/Study) under the server DICOM Settings Screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_024 : To verify that software shall have an option to change the study instance UID type from "SCP" to "SCU" in the Server -> DICOM -> DICOM settings screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1136616()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141317 :: Pre-Condition : Application should be running. Dicom package should be installed. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141318 :: 1. Press Menu > Settings button on Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141319 :: 2. Navigate to Server -> DICOM Tab and then to Settings button. 2. DICOM Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141320 :: 3. Observe the existence of Study Instance UID button and its default state. 3. The Study Instance UID button should be available and its default state should be SCU.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141321 :: 4. Change the Study Instance Id toggle button to SCP. 4. Study Instance should be successfully changed to SCP.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141322 :: 5. Change the Study Instance Id toggle button to SCU. 5. Study Instance should be successfully changed to SCU.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall have an option to change the study instance UID type from "SCP" to "SCU" in the Server -> DICOM -> DICOM settings screen.<br>"
			+"Actual : To verify that software shall have an option to change the study instance UID type from "SCP" to "SCU" in the Server -> DICOM -> DICOM settings screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_025 : To verify that there shall be a control in the Server -> DICOM -> DICOM settings screen which will allow the Storage Commit functionality to be turned On or Off.")]
[Owner("Gaurav Dhumal")]
public void TC_1136611()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141323 :: Pre-Condition : Application should be running. Dicom package should be installed.
 
DICOM server client settings should be configured in Menu>Settings>Server>DICOM Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141324 :: 1. Press Menu > Settings button on Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141325 :: 2. Navigate to Server -> DICOM Tab and then to Settings button. 2. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141326 :: 3. Observe the existence of Storage Commit button and its default state. 3. The Storage Commit button should be available and its default state should be OFF.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141327 :: 4. Change the Storage Commit toggle button to ON. 4. Storage Commit should be successfully changed to ON.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141328 :: 5. Change the Storage Commit toggle button to OFF. 5. Storage Commit should be successfully changed to OFF.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that there shall be a control in the Server -> DICOM -> DICOM settings screen which will allow the Storage Commit functionality to be turned On or Off.<br>"
			+"Actual : To verify that there shall be a control in the Server -> DICOM -> DICOM settings screen which will allow the Storage Commit functionality to be turned On or Off.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_026 : To verify that the software shall display : DICOM Video settings will apply on New case , on toggling the DICOM Video On/Off option.")]
[Owner("Gaurav Dhumal")]
public void TC_1136631()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141329 :: Preconditions:
a. Launch the application.
b. DICOM package should be installed and DICOM Client/Server settings are configured.
c. Channel Mode should be set to Single in Settings>System> General>Record Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141330 :: 1. From home screen, navigate to Settings->Server->DICOM->settings screen. 1. The DICOM settings screen should be displayed with video option should be turned Off.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141331 :: 2. Turn On the DICOM Video option by pressing the toggle button. 2. An information message should be displayed as DICOM Video settings will apply on New case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141333 :: 3. Turn Off the DICOM Video option by pressing the toggle button. 3. An information message should be displayed as DICOM Video settings will apply on New case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall display : DICOM Video settings will apply on New case , on toggling the DICOM Video On/Off option.<br>"
			+"Actual : To verify that the software shall display : DICOM Video settings will apply on New case , on toggling the DICOM Video On/Off option.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_027 : To verify that there shall be a control in the Server -> DICOM -> DICOM settings screen which will allow the Storage Commit Association to be either One Way or Two Way.")]
[Owner("Gaurav Dhumal")]
public void TC_1136637()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141334 :: Pre-Condition :
1.SDC4K Application should be running.
2.Dicom package should be installed. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141335 :: 1. Press Menu > Settings button on Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141336 :: 2. Navigate to Server -> DICOM Tab. Add connection name and configure Server/Client settings then navigate to Settings tab. 2. DICOM Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141337 :: 3. Turn ON the Storage Commit in DICOM 3. Storage Commit should be turned ON.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141338 :: 4. Observe the existence toggle button for Storage Commit Association. 4. The Storage Commit Association toggle button should be available.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141339 :: 5. Change the Storage Commit Association toggle button to Two-Way. 5. Storage Commit Association should be successfully changed to Two-Way.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141340 :: 6. Change the Storage Commit Association toggle button to One-Way. 6. Storage Commit Association should be successfully changed to One-Way.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that there shall be a control in the Server -> DICOM -> DICOM settings screen which will allow the Storage Commit Association to be either One Way or Two Way.<br>"
			+"Actual : To verify that there shall be a control in the Server -> DICOM -> DICOM settings screen which will allow the Storage Commit Association to be either One Way or Two Way.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_028 : To verify that Storage Commit Association works fine when configured to Two Way.")]
[Owner("Gaurav Dhumal")]
public void TC_1136645()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141341 :: Pre-Condition : Application should be running.
A valid DICOM server should be configured in SDC4K. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141342 :: 1. Press Menu > Settings button on Home screen. 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141343 :: 2. Press the Server -> DICOM -> Settings Button 2. A screen with several options should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141344 :: 3. Turn ON Storage commit by pushing the button 3. Storage Commit will be turned ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141345 :: 4. Set the Storage Commit Association to TWO-WAY 4. Two way storage commit should be selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141346 :: 5. Go to the Server/Client Settings and enter Port under client setting as 104 and save. 5. The Port number setting should be saved.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141347 :: 6. Navigate to Home screen and press Start Case button to create a new case. 6. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141348 :: 7. Enter patient details and navigate to Capture screen. Click few images. 7. Few Images should be captured successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141349 :: 8. Navigate to Media Gallery, select all images and click on export button. 8. Images should be selected and Export screen should be visible.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141350 :: Select Dicom and choose appropriate connection from dropdown and click on export. Case should be successfully saved to the Dicom server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141351 :: Close the export screen and verify storage commit is successful by observing the images present on the media gallery screen of the current case. The images should be having storage commit icon on the media gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that Storage Commit Association works fine when configured to Two Way.<br>"
			+"Actual : To verify that Storage Commit Association works fine when configured to Two Way.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_029 : To verify that software shall support enabling / disabling of DICOM video functionality.")]
[Owner("Gaurav Dhumal")]
public void TC_1136628()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141352 :: Precondition:
a. Launch the application.
b. DICOM package should be installed and DICOM settings should be configured.
c. Channel Mode should be Single. Precondition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141353 :: 1. Click on the Menu -> Settings button from Home screen (DICOM package should be enabled on the SDC4K machine). 1. Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141354 :: 2. Click on the Server button and then click on the DICOM tab. 2. The DICOM Server/Client settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141355 :: 3. Configure a dicom server setting in the Server/Client setting and click on the Settings button in the DICOM tab. 3. A valid DICOM server should be properly configured and the DICOM Settings screen should be displayed when clicking on the Settings button.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141356 :: 4. Observe the existence of DICOM Video button and its default state. 4. The DICOM Video button should exist and its default state should be displayed as OFF.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141357 :: 5. Enable the DICOM Video option by clicking on its toggle button. 5. DICOM Video option should be turned ON. Message Dicom Video settings will apply on New case should be displayed in the status bar at the bottom of the screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141358 :: 6. Navigate to Home screen and click on Start Case button. 6. A pop-up message Do you want to save videos to PACS? should appear with Yes and No buttons");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141359 :: 7. Press the Yes button. 7. Pop up message should close and Patient Info screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141361 :: 8. Navigate to Menu->Settings-> Server-> DICOM and turn Off the DICOM video option from Settings screen of DICOM tab. 8. DICOM Video option should be set to Off and a status message should be displayed as Dicom Video settings will apply on New case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141362 :: 9. End the current case. Navigate to Home screen and click on Start Case button. 9. No pop up message as Do you want to save videos to PACS? should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that software shall support enabling / disabling of DICOM video functionality.<br>"
			+"Actual : To verify that software shall support enabling / disabling of DICOM video functionality.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_030 : To verify that the software shall enable DICOM related options only if the saleable option for DICOM is activated in the device.dat file.")]
[Owner("Gaurav Dhumal")]
public void TC_1135804()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141363 :: Preconditions:
1. Make sure the DICOM Package is not currently activated on the SDC4K device.
2.Task Manager should already be open using the Task Manager Dongle
 3.CryptoApp should be installed and open to decrypt/encrypt the device.dat file.
4.SDC4K application should be running. Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141364 :: Navigate to Menu--> Settings --> Server and observe the DICOM tab. DICOM tab should be disabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141365 :: Navigate to D: -> Executables -> SMS Data and decrypt the device.dat file using the crypto app. The device.dat file should be successfully decrypted.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141366 :: Open decrypted file and observe the value under the parameters approved and currentStatus. The value in both the parameters should be N");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141367 :: Now activate the DICOM package and reboot the SDC4K device. SDC4K device should reboot successfully and the DICOM Package should be activated now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141368 :: Navigate to Menu--> Settings --> Server and observe the DICOM tab. DICOM tab should be enabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141369 :: Navigate to D: -> Executables -> SMS Data and decrypt the device.dat file using the crypto app. The device.dat file should be successfully decrypted.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141370 :: Open decrypted file and observe the value under the parameters approved and currentStatus. The value in approved parameters should be Y and currentStatus parameter should be A");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall enable DICOM related options only if the saleable option for DICOM is activated in the device.dat file.<br>"
			+"Actual : To verify that the software shall enable DICOM related options only if the saleable option for DICOM is activated in the device.dat file.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_031 : Verify that the software shall allow the operator to export multiple cases to PACS server at a time when choose from the archived case list.")]
[Owner("Gaurav Dhumal")]
public void TC_1136387()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141371 :: Pre-requisite:
1.SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141372 :: Navigate to Menu > Archived Cases Archived cases Screen should be displayed and it should display all the cases available in the hard disk.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141373 :: Select multiple archive cases by checking the checkbox associated with every case displayed in the grid. The Archive cases should be selected & the export button should also get enabled");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141374 :: Click on the Export button. The Export screen will be displayed which will display all the different storage mediums.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141375 :: Select DICOM and click on the Export button. The Export operation should be successful.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall allow the operator to export multiple cases to PACS server at a time when choose from the archived case list.<br>"
			+"Actual : Verify that the software shall allow the operator to export multiple cases to PACS server at a time when choose from the archived case list.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_032 : Verify that the archive cases shall have visual representation for each image and video which was successfully sent for Storage Commit operation.")]
[Owner("Gaurav Dhumal")]
public void TC_1136328()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141376 :: Pre-requisite:
1.SDC4K application should be installed and running . Dicom package should be installed.
2. A valid DICOM server should be configured on the SDC4K application with Storage Commit ON and Dicom Video ON. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141377 :: Create a new case from home screen and verify the Do you want to save videos to PACS? popup message should be displayed with yes and no button. Do you want to save videos to PACS? popup message with yes and no button should be coming on the SDC4K application GUI as the DICOM Video setting is ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141378 :: Click on Yes button, verify pop message should be closed and user should be navigated to patient info screen. User should be navigated to Patient info screen and pop up message should be closed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141379 :: Enter valid data in the Patient ID, Patient First Name and Patient Last Name text fields. The data should be entered successfully in the Patient ID, Patient First Name and Patient Last Name text fields.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141380 :: Navigate to the Capture screen. The operator should be directed to the Capture screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141381 :: Capture few images/videos by clicking the Capture button The images/videos should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141382 :: Navigate to Media Gallery and click on the Export button. The operator should be directed to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141383 :: Select the Dicom server and click on the Export button The Dicom server should be selected and the export to DICOM server should initiate and the messages should be coming in the below mentioned sequence:
Preparing data…
Saving data to PACS…
Save successful to PACS.
Committing data to PACS…
Storage Commit successful. as information message if all the selected images are successfully committed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141384 :: End the current case by clicking on the End Case tab The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141385 :: Navigate to Menu > Archived Cases The View Archive : Case window should be launched");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141386 :: Search and select the case ended in previous steps The case ended in previous steps should get selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141387 :: Click on the View Archive button The operator should be directed to the View Archive Screen with archived case details.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141388 :: Click on the Media Gallery button The media gallery should be having a storage commit icon on the top left corner of the image/video committed successfully to the DICOM server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the archive cases shall have visual representation for each image and video which was successfully sent for Storage Commit operation.<br>"
			+"Actual : Verify that the archive cases shall have visual representation for each image and video which was successfully sent for Storage Commit operation.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_033 : Verify that the software shall handle errors in case of a network failure and shall display appropriate error messages")]
[Owner("Gaurav Dhumal")]
public void TC_1135663()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141389 :: Pre-requisite: 1. SDC4K application should be installed and running
2. DICOM package should be installed Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141390 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141391 :: Navigate to Menu > Settings > Server > DICOM tab and verify that Dicom settings screen should get displayed DICOM settings screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141392 :: Select the blank option from the Connection Name drop down field and enter a valid Dicom server name in the Connection Name drop down The Dicom server name should get entered in the Connection Name drop down field");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141393 :: Click on the Add button The Dicom server name should get added successfully in the Connection Name drop down");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141394 :: Enter valid data in the AE Title, IP Address and Port fields present for Store, MWL, Q/R and S.C. settings, click on the Save button The application should throw a message on the global task bar saying Save successful.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141395 :: Modify the IP Address of the Store setting to an IP Address (for e.g. 10.80.0.3) which does not belong to any valid DICOM server and click on the Save button The IP Address of the Store setting should get updated");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141396 :: Click on the Echo button present in front of the Store setting The SDC4K application should throw an error message on the global task bar saying Echo failed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall handle errors in case of a network failure and shall display appropriate error messages<br>"
			+"Actual : Verify that the software shall handle errors in case of a network failure and shall display appropriate error messages");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_034 : Verify that the software store the study instance UID in the CaseDetails.xml file (This XML file shall be saved as .dat file on the SDC4K)  as the attribute under the patient info tag if the case is retrieved from MWL search; otherwise the software shall store the empty UID.")]
[Owner("Gaurav Dhumal")]
public void TC_1136274()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141397 :: Pre-requisite: 1. Task Manager should already be open using the Task Manager Dongle.
2. SDC4K application should be installed and running
3. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON
4. PACS should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141398 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141399 :: Enter a valid Patient ID (which is having DICOM images in prior studies) in the Patient Id field Details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141400 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141401 :: Select the Date Range as ALL and click on the Search button. The application should display the list of cases matching the selected Patient Id.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141402 :: Select the patient Id and click on the Studies button. The application should display the list of series matching the selected Patient Id. Under every study, the available series should be present with information regarding images count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141404 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141405 :: Select all the images and click on Add to Album button. All the images should be added in the Media Gallery of the current case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141406 :: Navigate to Capture screen. The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141407 :: Capture an image by clicking the Capture button Image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141408 :: End the current case by clicking the End Case tab The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141409 :: Navigate to the E:\Data folder and open the case folder associated with the case created above Operator should navigate to the case folder created above inside the E:\Data folder");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141410 :: Open the CaseDetails.dat file by decrypting it using decryption tool into xml file and verify the presence of studyinstanceuid attribute The studyinstanceuid attribute should present inside the CaseDetails.dat file and should be having the Study Instance UID in it");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141411 :: Repeat the above test steps without retrieving the case from Dicom Server. CaseDetails.dat file should not be having the Study Instance UID in it.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software store the study instance UID in the CaseDetails.xml file (This XML file shall be saved as .dat file on the SDC4K)  as the attribute under the patient info tag if the case is retrieved from MWL search; otherwise the software shall store the empty UID.<br>"
			+"Actual : Verify that the software store the study instance UID in the CaseDetails.xml file (This XML file shall be saved as .dat file on the SDC4K)  as the attribute under the patient info tag if the case is retrieved from MWL search; otherwise the software shall store the empty UID.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_035 : Verify that the software display an error message to the operator in case an error occurs during MWL Search")]
[Owner("Gaurav Dhumal")]
public void TC_1136276()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141412 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON
3. PACS and USB should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141413 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141414 :: Navigate to Menu > Settings > Server > DICOM tab and verify that Dicom settings screen should get displayed DICOM settings screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141415 :: Change the IP Address in the DICOM server configuration settings to any IP Address which does not belong to a valid DICOM server, for e.g. 10.80.0.33 and click on the Save button The IP Address of the should get updated to the newly assigned IP Address");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141416 :: Close the setting screen and navigate to SDC4K home screen. SDC4K Home screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141417 :: Create a new case from home screen and verify the message displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141418 :: Click Yes. New case should be created and operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141419 :: Click on the PACS button The Import from PACS window should get launched");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141420 :: Click on the Search button and verify the error message on the global task bar The SDC4K application should throw an error message on the global task bar saying Error retrieving MWL.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software display an error message to the operator in case an error occurs during MWL Search<br>"
			+"Actual : Verify that the software display an error message to the operator in case an error occurs during MWL Search");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_036 : Verify that the software shall display an error message to the operator in case an error occurs during retrieving patient studies, series or images/videos")]
[Owner("Gaurav Dhumal")]
public void TC_1136314()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141421 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON.
3. SDC4K should be connected to network through LAN. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141422 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141423 :: Create a new case from home screen and verify the pop up message displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141424 :: Click Yes. New case should be created and operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141425 :: Click on the PACS button The Import from PACS window should get launched");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141426 :: Take out the network cable from the SDC4K machine , enter a valid Last Name and click on Search button. The application should throw an error message on the global task bar saying Retrieving MWL.. and Error retrieving MWL.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141427 :: Enter a valid Last Name and click on Search Studies button. The application should throw an error message on the global task bar saying Retrieving Study list... and Patient not found.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141428 :: Plug in the network cable, enter valid search criteria and click on search studies button. Search Result should be displayed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141429 :: Expand any study by clicking on the expander associated to it. Select any series which has media in it. Series should be selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141430 :: Take out the network cable and select any series. Click on Import Images/Videos button. Import Images/Videos screen should be dispalyed and the application should throw an error message on the global task bar saying Retrieving Images and Videos.. and Error retrieving media.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display an error message to the operator in case an error occurs during retrieving patient studies, series or images/videos<br>"
			+"Actual : Verify that the software shall display an error message to the operator in case an error occurs during retrieving patient studies, series or images/videos");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_037 : Verify that the software initiate MWL search automatically from the GUI. Also verify software shall disable both the Import Patient Details, Import Images/Videos button by default and enable Import Patient Details, Import Images/Videos button only when a series is selected.")]
[Owner("Gaurav Dhumal")]
public void TC_1136296()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141431 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. Dicom package should be installed and configured. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141432 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141433 :: Enter Patient ID or Patient Name for which MWL record exist and click on the search PACS button from the Patient Info screen. Verify Auto MWL should be triggered. The Import from PACS window should be displayed. Auto MWL should be triggered and result should be displayed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141434 :: Verify state of Import Patient Details, Import Images/Videos button if data is retrieved from auto MWL search Import Patient Details, Import Images/Videos button should be disabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141435 :: Enter a search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141436 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141437 :: Select a series having images/videos Series row should get highlighted");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141438 :: Verify state of Import Patient Details, Import Images/Videos button Import Patient Details, Import Images/Videos button should be enabled now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software initiate MWL search automatically from the GUI. Also verify software shall disable both the Import Patient Details, Import Images/Videos button by default and enable Import Patient Details, Import Images/Videos button only when a series is selected.<br>"
			+"Actual : Verify that the software initiate MWL search automatically from the GUI. Also verify software shall disable both the Import Patient Details, Import Images/Videos button by default and enable Import Patient Details, Import Images/Videos button only when a series is selected.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_038 : Verify that the software shall have a default value of Today for the Date Range field and software shall have either of the two options for the Date Range field:
1. All
2. Today")]
[Owner("Gaurav Dhumal")]
public void TC_1136297()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141439 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141440 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141442 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141443 :: Verify the search criteria fields present on the Import from PACS window and default value of Date Range field. The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as default. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141444 :: Verify options in Date range field Date range drop down should have two option
1: All
2:Today");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141445 :: Select the value as Today from the Date Range drop down The value should be selected as Today in the Date Range drop down field");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141446 :: Enter search criteria and click on the Search / Search studies button. The search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141447 :: Verify all the search results are populating as per the search criteria where the date range is set as Today The application should search and display all the patient details which is having the procedure start date as todays date");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141448 :: Select the value as ALL from the Date Range drop down The value should be selected as ALL in the Date Range drop down field");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141449 :: Enter search criteria and click on the Search / Search studies button The search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141450 :: Verify all the search results are populating as per the search criteria where the date range is set as ALL The application should search and display all the patient details which is having the procedure start date as ALL");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall have a default value of Today for the Date Range field and software shall have either of the two options for the Date Range field:
1. All
2. Today<br>"
			+"Actual : Verify that the software shall have a default value of Today for the Date Range field and software shall have either of the two options for the Date Range field:
1. All
2. Today");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_039 : Verify that the software be able perform MWL find based on modality and default value of modality field shall be "ALL".")]
[Owner("Gaurav Dhumal")]
public void TC_1136298()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141451 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141452 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141453 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141454 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them as default value
The Date Range drop down field should have Today value as default. The Modality drop down should have ALL value as Default");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141455 :: Select the value as ES from the Modality drop down The value should be selected as ES in the Modality drop down field");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141456 :: Enter search criteria and click on the Search or Search Studies as per the search criteria. Verify all the search results are populating as per the search criteria where the Modality is set as ES The application should search and display all the patient details which is having the modality as ES");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141457 :: Select the value as ALL from the Modality drop down The value should be selected as ALL in the Modality drop down field");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141458 :: enter search criteria and click on the Search or Search Studies as per the search criteria The application should search and display all the patient details which is having the modality as ALL");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software be able perform MWL find based on modality and default value of modality field shall be "ALL".<br>"
			+"Actual : Verify that the software be able perform MWL find based on modality and default value of modality field shall be "ALL".");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_040 : To verify that the the software shall allow for search with wild card(*) fields and when user leaves any parameter empty that parameter should be filled by wild card(*). Also verify all the fields i.e.( PatientId, First Name, Last Name, Station) have a default value of asterisk (*).")]
[Owner("Gaurav Dhumal")]
public void TC_1136285()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141459 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141460 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141461 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141462 :: Verify all the fields present on the Import from PACS screen i.e.( PatientId, First Name, Last Name, Station) have a default value of asterisk (*). The Patient Id, First Name , Last Name and Station name fields should have asterisk (*) as default value.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141463 :: Enter * in the Last and First Name field, enter any valid Patient Id (for e.g. 2333) in the Patient Id field The First Name field and the Last Name field should have * and the Patient Id field should have 2333");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141464 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141465 :: Verify all the search results are populating as per the search criteria. The application should search and display all the patient details as per the current search criteria. Wild card search is performed for the First and Last Name field.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141466 :: Enter * in the Patient ID and Last Name field. Enter any valid First Name (for e.g. Rohit) in the First Name field The Last Name and Patient Id field field should have * and the First Name field should have Rohit");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141467 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141468 :: Verify all the search results are populating as per the search criteria. The application should search and display all the patient details as per the current search criteria. Wild card search is performed for the Patient Id field and Patient Last Name");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141469 :: Enter * in the Patient ID and First Name field. Enter any valid Last Name (for e.g. Goel) in the Last Name field The First Name and Patient Id field field should have * and the Last Name field should have Goel");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141470 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141471 :: Verify all the search results are populating as per the search criteria. The application should search and display all the patient details as per the current search criteria. Wild card search is performed for the Patient Id field and Patient First Name");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141472 :: Verfiy when user leave any field empty(First Name,Last Name, Station, Patient ID) empty and remove focus from that field then that field should be filled with * The respective field should be filled with * if that field is left empty and focus is been removed from that field.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the the software shall allow for search with wild card(*) fields and when user leaves any parameter empty that parameter should be filled by wild card(*). Also verify all the fields i.e.( PatientId, First Name, Last Name, Station) have a default value of asterisk (*).<br>"
			+"Actual : To verify that the the software shall allow for search with wild card(*) fields and when user leaves any parameter empty that parameter should be filled by wild card(*). Also verify all the fields i.e.( PatientId, First Name, Last Name, Station) have a default value of asterisk (*).");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_041 : Verify that the software shall display Refine search criteria message when search studies button is clicked, date range is set to All and the following fields are set to asterisk (*)
1. PatientId
2. First Name
3. Last Name
4. Station Name")]
[Owner("Gaurav Dhumal")]
public void TC_1136292()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141473 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141474 :: Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141475 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141476 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station Name, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141477 :: Set Date Range to ALL and click on the Search Studies button Refine Search Criteria message should appear in global task bar");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display Refine search criteria message when search studies button is clicked, date range is set to All and the following fields are set to asterisk (*)
1. PatientId
2. First Name
3. Last Name
4. Station Name<br>"
			+"Actual : Verify that the software shall display Refine search criteria message when search studies button is clicked, date range is set to All and the following fields are set to asterisk (*)
1. PatientId
2. First Name
3. Last Name
4. Station Name");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_042 : Verify that the system shall display "Retrieving study list" in global task bar when clicked on search studies button.")]
[Owner("Gaurav Dhumal")]
public void TC_1136303()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141478 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141479 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141480 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141482 :: Verify the search criteria fields present on the Search PACS window The Patient Id, Station, First Name and Last Name fields should have *, in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141483 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141484 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141485 :: Select any patient id and click on the Search Studies button Retrieving study list should be displayed in global task bar");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display "Retrieving study list" in global task bar when clicked on search studies button.<br>"
			+"Actual : Verify that the system shall display "Retrieving study list" in global task bar when clicked on search studies button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_043 : Verify data format as below
The system shall display patient information in the following format:
last name first name,(Patient id), date of birth and gender.
The system shall display each study in the following format:
Study Id: Procedure Name (Date and time)
The system shall display series under each study with the following attributes:
i) Series Number
ii) Total Assets Number
ii) Modality type")]
[Owner("Gaurav Dhumal")]
public void TC_1136295()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141486 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application
4. Set Retrieve Method to C-Get from Menu > Settings > Server > DICOM Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141487 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141488 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141489 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141490 :: Enter Patient ID or Patient name to perform search. The Patient ID or Patient name should be entered to perform search.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141491 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141492 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141493 :: Select any searched patient data and click on the Search Studies button The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding images count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141494 :: Verify patient information in search results System should display patient information in the following format:
last name first name,(Patient id), date of birth and gender.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141495 :: Verify Study id information in search results System should display each study in the following format:
Study Id: Procedure Name(Date and Time)");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141496 :: Verify series attribute under study System should display series under each study with the following attributes:
 
i) Series Number
ii) Total Assets Number
ii) Modality type");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify data format as below
The system shall display patient information in the following format:
last name first name,(Patient id), date of birth and gender.
The system shall display each study in the following format:
Study Id: Procedure Name (Date and time)
The system shall display series under each study with the following attributes:
i) Series Number
ii) Total Assets Number
ii) Modality type<br>"
			+"Actual : Verify data format as below
The system shall display patient information in the following format:
last name first name,(Patient id), date of birth and gender.
The system shall display each study in the following format:
Study Id: Procedure Name (Date and time)
The system shall display series under each study with the following attributes:
i) Series Number
ii) Total Assets Number
ii) Modality type");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_044 : Verify that the software shall by default enable the Search and Search Studies button.")]
[Owner("Gaurav Dhumal")]
public void TC_1136302()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141497 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141498 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141499 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141500 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141501 :: Verify Search and Search Studies button should be enabled by default. Search and Search Studies button should be enabled by default");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall by default enable the Search and Search Studies button.<br>"
			+"Actual : Verify that the software shall by default enable the Search and Search Studies button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_045 : Verify that the software support to query and retrieve the patient information and images that are saved in the DICOM server as part of existing (current) patient record")]
[Owner("Gaurav Dhumal")]
public void TC_1136301()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141502 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. DICOM package should be installed.
3. A valid DICOM server should be configured. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141503 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141504 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141505 :: Verify all the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141506 :: Enter any Patient Id (Say 2333). Set the Date Range and Modality as ALL and click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141507 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141508 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the import process, and should display all the imported images on the Import Images/Videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support to query and retrieve the patient information and images that are saved in the DICOM server as part of existing (current) patient record<br>"
			+"Actual : Verify that the software support to query and retrieve the patient information and images that are saved in the DICOM server as part of existing (current) patient record");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_046 : Verify that the software allow filling the current case with the patient information retrieved from DICOM server using MWL Find operation")]
[Owner("Gaurav Dhumal")]
public void TC_1136299()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141509 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images in it Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141510 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141511 :: Click on the search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141512 :: Enter the search criteria and click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141513 :: Select any patient id from the searched results and click on the Import Patient Details button. The application should load the patient details in the respective fields of the Patient Info screen(Current case).");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software allow filling the current case with the patient information retrieved from DICOM server using MWL Find operation<br>"
			+"Actual : Verify that the software allow filling the current case with the patient information retrieved from DICOM server using MWL Find operation");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_047 : To verify that the software shall support retrieval of Series with Study Root query.")]
[Owner("Gaurav Dhumal")]
public void TC_1135688()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141514 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Patient Search Should be selected as DICOM in settings.
4. Select Retrieve Level as Study on Dicom server settings. A case having few Images and Videos should be available for retrieval. Pre-conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141515 :: Create a New Case by pressing Start Case Button from Home Screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141516 :: On Patient Info screen, click on Search PACS button. Import from PACS Screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141517 :: Enter the Valid Patient ID,Select Date Range and Modality as All and Press on Search button. Patient List should be displayed matching the specified Search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141518 :: Select any Patient ID and Press on Search Studies button. Studies list should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141519 :: From Study list, Verify that series should also be displayed as the child nodes of a specific study. Select any series and Press on Import Patient Details button. User should be able to select study and series.
Series list should be retrieved successfully and Patient Info screen should get filled up with the info of the patient selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall support retrieval of Series with Study Root query.<br>"
			+"Actual : To verify that the software shall support retrieval of Series with Study Root query.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_048 : Verify that the software support Prior Studies Search from DICOM Server")]
[Owner("Gaurav Dhumal")]
public void TC_1136277()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141521 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images in it Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141522 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141523 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141524 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141525 :: Enter Patient Id (say 2333) in the Patient Id field and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141526 :: Select the patient id and click on the Search Studies button The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141527 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the import process, and should display all the imported images on the Import Images/Videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support Prior Studies Search from DICOM Server<br>"
			+"Actual : Verify that the software support Prior Studies Search from DICOM Server");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_049 : Verify that the Patient ID, Patient Name (Last Name, First Name), Modality, Procedure Date and Station Name are the fields included in the MWL Search Criteria")]
[Owner("Gaurav Dhumal")]
public void TC_1136344()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141528 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with Retrieval Method as C-Get Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141529 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141530 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141531 :: Verify all the search criteria fields present on the Import from PACS window The Patient Id, First Name, Last Name and Station Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141532 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141533 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the Patient ID, Patient Name (Last Name, First Name), Modality, Procedure Date and Station Name are the fields included in the MWL Search Criteria<br>"
			+"Actual : Verify that the Patient ID, Patient Name (Last Name, First Name), Modality, Procedure Date and Station Name are the fields included in the MWL Search Criteria");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_050 : Verify that if DICOM data is retrieved using MWL functionality, this shall form a new study when this case is stored to a DICOM destination")]
[Owner("Gaurav Dhumal")]
public void TC_1136345()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141534 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3.Study Instance UID should be set to SCU Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141535 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141537 :: Enter valid Patient ID for search in the Patient Id field. The search details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141538 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141539 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141540 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141541 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding images count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141542 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141543 :: Select any available DICOM images and click on Add to Album button to add the retrieved images to the Media Gallery of the current case The Import from PACS window should get closed and the operator should navigate to the Patient Info Screen. Also the images should be added to the Media Gallery of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141544 :: Navigate to the Capture screen and Capture 2 images by clicking the Capture button. The operator should navigate to the Capture screen and 2 images should get captured.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141545 :: Navigate to the Media Gallery screen and select All images/videos and click Export button Export Screen should be displayed .");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141546 :: Select DICOM and de-select all the other Export options from the Export screen. The DICOM export option should get selected successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141547 :: Click on the Export button to export the images to the DICOM server. All images should be saved with other related data (Patient Info) to the DICOM server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141548 :: End the case by clicking the End Case tab. The current case should end successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141549 :: Click on the Start Case button from the Home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141550 :: Enter the same Patient ID in the Patient Id field which was entered in the step #3 and click on the search PACS button The Patient ID should get entered in the patient id field and the Import from PACS window should be launched successfully and auto MWL search should be triggered");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141551 :: Select the patient id and click on the Search Studies button New prior study should be added to the list and existing studies should be displayed as search result.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that if DICOM data is retrieved using MWL functionality, this shall form a new study when this case is stored to a DICOM destination<br>"
			+"Actual : Verify that if DICOM data is retrieved using MWL functionality, this shall form a new study when this case is stored to a DICOM destination");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_051 : Verify that the software create a new Series for the selected patient when DICOM Setting Study Instance UID is set to SCP.")]
[Owner("Gaurav Dhumal")]
public void TC_1136304()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141553 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with Study Instance UID setting set to SCP Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141554 :: Launch the SDC4K application and start a new case. The SDC4K application should be launched successfully and new case should be started. User should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141555 :: Click on the Search PACS button The operator should land on the Import from PACS screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141556 :: Enter Search criteria and perform Study search operation, select any case and import images from the server to the current case. Note: The selected case should be having DICOM images The case should be successfully imported with patient details and images. The operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141557 :: Navigate to the Capture screen The operator should land on the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141558 :: Capture few images by clicking the Capture button Images should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141559 :: Click on the Media Gallery and select all the Images that are clicked The operator should navigate to the Media Gallery screen and the operator should be able to select all the images");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141560 :: Click Export button and Select DICOM and de-select all the other Export options from the Export screen. The DICOM export option should get selected successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141561 :: Click on the Export button to export the images to the DICOM server. All images should be saved with other related data (Patient Info) to the DICOM server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141562 :: End the current case. The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141563 :: Click on the Start Case button present on the Home screen New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141564 :: Click on the Search PACS button and search for the patient selected above while creating the case The case should get searched for the patient which was used to create the case above");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141565 :: Verify that a new series should be created under the existing study A new series should be created under the existing study");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software create a new Series for the selected patient when DICOM Setting Study Instance UID is set to SCP.<br>"
			+"Actual : Verify that the software create a new Series for the selected patient when DICOM Setting Study Instance UID is set to SCP.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_052 : Verify that the software shall display the text "SPECIALTY" in the specialty field of Patient Info Screen when a patient with a procedure is retrieved from MWL server if Specialty is not present on server.")]
[Owner("Gaurav Dhumal")]
public void TC_1136326()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141566 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server which has procedure name in it and no specialty in it. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141567 :: Launch the SDC4K application and start a new case from the home screen. The SDC4K application should be launched successfully and new case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141568 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141569 :: Enter the Patient Id in the Patient Id field which is having procedure mentioned in its existing case. Select Date Range as ALL and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141570 :: Select the patient id and click on the Import Patient Details button The application should import all the available patient related data and fill the desired fields on the Patient Info screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141571 :: Verify the Specialty field on the Patient Info screen The text SPECIALTY should be populated in the Specialty field by the SDC4K application");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display the text "SPECIALTY" in the specialty field of Patient Info Screen when a patient with a procedure is retrieved from MWL server if Specialty is not present on server.<br>"
			+"Actual : Verify that the software shall display the text "SPECIALTY" in the specialty field of Patient Info Screen when a patient with a procedure is retrieved from MWL server if Specialty is not present on server.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_053 : Verify that the software shall display the text "SPECIALTY" in the specialty field of Patient Screen when a patient with a procedure is retrieved from MWL server if Specialty is not present on server.")]
[Owner("Gaurav Dhumal")]
public void TC_1136325()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141572 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server which has procedure name in it and no specialty in it.
4.PACS should be selected under the Patient Search in the Application setting. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141573 :: Launch the SDC4K application and press the Patients button on the Home screen The SDC4K application should be launched successfully and operator should land on the Patients screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141574 :: Click on the PACS button from the Patient screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141575 :: Enter the Patient Id in the Patient Id field which is having procedure mentioned in its existing case. Select Date Range as ALL and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141576 :: Select the patient id and click on the Import Patient Details button The application should import all the available patient related data and fill the desired fields on the Patients screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141577 :: Verify the Specialty field on the Patients screen The text SPECIALTY should be populated in the Specialty field");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display the text "SPECIALTY" in the specialty field of Patient Screen when a patient with a procedure is retrieved from MWL server if Specialty is not present on server.<br>"
			+"Actual : Verify that the software shall display the text "SPECIALTY" in the specialty field of Patient Screen when a patient with a procedure is retrieved from MWL server if Specialty is not present on server.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_054 : Verify that the software should create a new Study for the selected patient when DICOM Setting Study Instance UID is set to SCU and MWL search functionality is not used.")]
[Owner("Gaurav Dhumal")]
public void TC_1136306()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141578 :: Pre-requisite: 1. SDC4K application should be installed and running 2. A valid DICOM server should be configured on the SDC4K application with Study Instance UID setting set to SCU Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141579 :: Launch the SDC4K application and start a new case. The SDC4K application should be launched successfully and new case should be started. User should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141580 :: Click on the Search PACS button The operator should land on the Import from PACS screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141581 :: Enter Search criteria and perform search operation on studies server, select any case and imported images from the server
Note: The selected case should be having DICOM images The operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141582 :: Navigate to the Capture screen The operator should land on the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141583 :: Capture few images by clicking the Capture button Images should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141584 :: Click on Image icon and click on the Export button to navigate to the Export screen. The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141585 :: Select DICOM and de-select all the other Export options from the Export screen. Export the case to DICOM server. The DICOM export option should get selected successfully. Case should be exported to DICOM server successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141586 :: End the case by clicking the End Case button and click Yes present on the confirmation dialog box The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141587 :: Click on the Start Case button present on the Home screen New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141589 :: Click on the Search PACS button and search studies for the patient selected above while creating the case The case should get searched for the patient which was used to create the case above");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141590 :: Verify that a new study should be created A new study should be created by the system.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software should create a new Study for the selected patient when DICOM Setting Study Instance UID is set to SCU and MWL search functionality is not used.<br>"
			+"Actual : Verify that the software should create a new Study for the selected patient when DICOM Setting Study Instance UID is set to SCU and MWL search functionality is not used.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_055 : Verify that the system shall display text 'Search Results (Patient /Study /Series)' text on top of the data grid when Search Studies button is clicked.")]
[Owner("Gaurav Dhumal")]
public void TC_1136309()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141591 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. Dicom package should be activated.
3. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141592 :: Launch the SDC4K application and Create a new case from home screen. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141593 :: Click on the PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141594 :: Enter the search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141595 :: Verify the presence of the text Search Result (Patient /Study /Series) on the top of data grid. The text Search Result (Patient /Study /Series) should be present on the top of data grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display text 'Search Results (Patient /Study /Series)' text on top of the data grid when Search Studies button is clicked.<br>"
			+"Actual : Verify that the system shall display text 'Search Results (Patient /Study /Series)' text on top of the data grid when Search Studies button is clicked.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_056 : Verify that the system display each record with the following information:
Patient Info, followed by Study Information and associated series.")]
[Owner("Gaurav Dhumal")]
public void TC_1136286()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141596 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141597 :: Launch the SDC4K application and Create a new case from home screen. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141598 :: Click on the PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141599 :: Enter Search Criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141600 :: Wait for the search to finish and verify the following information in the records present in the search result grid:
Patient Info, followed by Study Information and associated series. After the search operation is finished the operator should see the information in the search records in the following fashion:
Patient Info (Last Name First Name (Patient Id: ) DoB: Gender: )
Study Id: <Study Info> (<Date>)
Series # Total Assets: <Asset Count> Modality: ES().");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system display each record with the following information:
Patient Info, followed by Study Information and associated series.<br>"
			+"Actual : Verify that the system display each record with the following information:
Patient Info, followed by Study Information and associated series.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_057 : To verify if the SDC allows the patient search option to PACS if DICOM package is activated.")]
[Owner("Gaurav Dhumal")]
public void TC_1135697()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141601 :: Pre Conditions :
1.SDC4K application should be running.
2.DICOM package should be activated.
3.EMR package should not be activated. Pre conditions are met");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141602 :: Go to Menu -> Settings -> System -> General Settings -> Application setting User should get navigated to the Application setting screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141603 :: Verify software shall provide toggle button under the Patient Search section and PACS option should be displayed in the toggle button. PACS should be displayed on the toggle button present under the Patient Search option.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141604 :: Try to toggle the value. System should not allow to toggle the value since EMR package is not activated");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify if the SDC allows the patient search option to PACS if DICOM package is activated.<br>"
			+"Actual : To verify if the SDC allows the patient search option to PACS if DICOM package is activated.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_058 : Verify that the system shall display patient last name, patient first name, patient id, date of birth and gender for each record.")]
[Owner("Gaurav Dhumal")]
public void TC_1136284()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141605 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141606 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141607 :: Click on the PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141608 :: Enter search criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141609 :: Wait for the search to finish and verify the following patient information in the records present in the search result grid:
patient last name, patient first name, patient id, date of birth and gender for each record. After the search operation is finished the operator should see the information in the search records in the following fashion: Last Name First Name (Patient Id: ) DoB: Gender:");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display patient last name, patient first name, patient id, date of birth and gender for each record.<br>"
			+"Actual : Verify that the system shall display patient last name, patient first name, patient id, date of birth and gender for each record.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_059 : Verify that the system shall display study id, followed by study description and date time for each record, if available.")]
[Owner("Gaurav Dhumal")]
public void TC_1136290()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141610 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141611 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141612 :: Click on the PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141613 :: Enter search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141614 :: Wait for the search to finish and verify the following study information in the records present in the search result grid:
study id, followed by study description and date time for each record. After the search operation is finished the operator should see the information in the search records in the following fashion:
Study Id: Procedure Name (Date Time).");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display study id, followed by study description and date time for each record, if available.<br>"
			+"Actual : Verify that the system shall display study id, followed by study description and date time for each record, if available.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_060 : Verify that the system shall display one of more series for each record in the format, Series Number, followed by number of assets and Modality.")]
[Owner("Gaurav Dhumal")]
public void TC_1136287()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141616 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141617 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141618 :: Click on the PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141619 :: Enter search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141620 :: Wait for the search to finish and verify the following study information in the records present in the search result grid:
Series Number, followed by number of assets and Modality for each record. After the search operation is finished the operator should see the information in the search records in the following fashion:
Series #(number) Total Assets: <Asset Count> Modality: ES");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display one of more series for each record in the format, Series Number, followed by number of assets and Modality.<br>"
			+"Actual : Verify that the system shall display one of more series for each record in the format, Series Number, followed by number of assets and Modality.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_061 : Verify that the system shall allow to highlight a series, if available.")]
[Owner("Gaurav Dhumal")]
public void TC_1136305()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141621 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141622 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141623 :: Click on the PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141624 :: Enter search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141625 :: Wait for the search to finish and verify the following study information in the records present in the search result grid:
Series Number, followed by number of assets and Modality for each record. After the search operation is finished the operator should see the information in the search records in the following fashion: Series # Total Assets: <Asset Count> Modality: ES");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141626 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue color in the search result section.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall allow to highlight a series, if available.<br>"
			+"Actual : Verify that the system shall allow to highlight a series, if available.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_062 : Verify that the software shall display the following fields after MWL search results
1. Patient Id
2. Patient Full name
3. Surgeon Name
4. Procedure Name
5. Procedure Date")]
[Owner("Gaurav Dhumal")]
public void TC_1136312()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141627 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141628 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141629 :: Click on the PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141630 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141631 :: Verify MWL search result data grid after MWL search gets completed Software shall display the following fields after MWL search results
1. Patient Id
2. Patient Full name
3. Surgeon Name
4. Procedure Name
5. Procedure Date");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display the following fields after MWL search results
1. Patient Id
2. Patient Full name
3. Surgeon Name
4. Procedure Name
5. Procedure Date<br>"
			+"Actual : Verify that the software shall display the following fields after MWL search results
1. Patient Id
2. Patient Full name
3. Surgeon Name
4. Procedure Name
5. Procedure Date");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_063 : Verity that the software shall have either of the two options for the modality field:
1. All
2. ES")]
[Owner("Gaurav Dhumal")]
public void TC_1136319()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141632 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. DICOM package should be installed.
3. A valid DICOM server should be configured on the SDC4K application.
4. Set Retrieve Method to C-Get from Menu > Settings > Server > DICOM Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141633 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141634 :: Click on the PACS button from the Patient Info screen. The Import from PACS window should be launched successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141635 :: Verify options for the modality field Software shall have either of the two options for the modality field:
1. All
2. ES");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verity that the software shall have either of the two options for the modality field:
1. All
2. ES<br>"
			+"Actual : Verity that the software shall have either of the two options for the modality field:
1. All
2. ES");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_064 : Verify that the software shall be able to perform MWL search with any of the following parameters:
1. Patient Id
2. First Name
3. Last Name
4. Date Range
5. Modality
6. Station")]
[Owner("Gaurav Dhumal")]
public void TC_1136320()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141636 :: Pre-requisite: 1. SDC4K application should be installed and running. 2. DICOM package should be installed. 3. A valid DICOM server should be configured on the SDC4K application. 4. Set Retrieve Method to C-Get from Menu > Settings > Server > DICOM Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141637 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141638 :: Click on the PACS button from the Patient Info screen. The Import from PACS window should be launched successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141639 :: Enter Patient Id and click on search button System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141640 :: Enter First Name and click on search System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141641 :: Enter Last Name and click on search System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141643 :: Select Data range as ALL and click on search button System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141644 :: Select Data range as Today and click on search button System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141645 :: Select Modality as ALL and click on search System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141646 :: Select Modality as ES and click on search button. System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141647 :: Enter Station name and click search button. System should display all records matching with enter criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall be able to perform MWL search with any of the following parameters:
1. Patient Id
2. First Name
3. Last Name
4. Date Range
5. Modality
6. Station<br>"
			+"Actual : Verify that the software shall be able to perform MWL search with any of the following parameters:
1. Patient Id
2. First Name
3. Last Name
4. Date Range
5. Modality
6. Station");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_065 : To verify that the software shall always use the current date for MWL Find operation from Patient Info screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1135673()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141648 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Patient Search Should be selected as DICOM in settings. Pre-Condition should be met successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141649 :: Create a New Case by pressing Start Case Button from Home Screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141650 :: On Patient Info screen Press PACS button It should display the Import from PACS Screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141651 :: Verify that default option for Date Range field. Default option for Date Range field should be Today.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall always use the current date for MWL Find operation from Patient Info screen.<br>"
			+"Actual : To verify that the software shall always use the current date for MWL Find operation from Patient Info screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_066 : The software shall allow the wild card search for patient id, patient name, etc for MWL Find operation.")]
[Owner("Gaurav Dhumal")]
public void TC_1135677()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141652 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Patient Search Should be selected as PACS in application settings. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141653 :: Create a New Case. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141654 :: On Patient Info screen, click on search PACS. Import from PACS Screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141656 :: Enter the Patient ID field as *, enter search criteria and press on Search button MWL Search should be successfully performed and a list of ALL patients should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141657 :: Enter the Patient ID field as P* and keep rest of the fields as blank. Press on Search button. MWL search should be successfully performed and a lot of patients should be displayed where Patient ID starts with P.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141658 :: Enter the Patient ID field as *P and keep rest of the fields as blank. Press on Search button.. MWL Search should be successfully performed and a lot of patients should be displayed where Patient ID ends with P.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141659 :: Enter the Patient ID field as P*D and keep rest of the fields as blank. Press on Search button.. MWL Search should be successfully performed and a lot of patients should be displayed where Patient ID starts with P and ends with D.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141660 :: Repeat the steps 3 - 6 above for the following fields:
1.First Name Field.
2.Last Name field All the above scenarios should also work the same way for the mentioned fields as well.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : The software shall allow the wild card search for patient id, patient name, etc for MWL Find operation.<br>"
			+"Actual : The software shall allow the wild card search for patient id, patient name, etc for MWL Find operation.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_067 : Verify that the software shall disable the patient Id,First Name, last name, DOB and gender fields which are retrieved from MWL server in patient info screen after selecting a patient from MWL server and also disable PACS button in Patient Information Screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1135675()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141661 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Patient Search Should be selected as PACS in settings.
4.Patient Id should exists which should have all the demographic data. Pre-Condition should be met successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141662 :: Create a New Case by pressing Start Case Button from Home Screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141663 :: Click on the Search PACS button from the Patient Info screen. The Import from PACS window should be launched successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141664 :: Enter search criteria and press the Search button. System should display all records matching with search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141665 :: Select any Patient ID (which has patient details)and click on Import Patient Details button. Patient Info screen should get filled up with the info of the patient selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141666 :: Verify that patient Id,First Name, last name, DOB and gender fields with information filled up from MWL are in Disabled state. Patient Id,First Name, last name, DOB and gender fields should be in Disabled state.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141667 :: Verify the Search PACS button displayed on Patient Information screen after retrieving the record(case data) from MWL. The Search PACS button should be disabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall disable the patient Id,First Name, last name, DOB and gender fields which are retrieved from MWL server in patient info screen after selecting a patient from MWL server and also disable PACS button in Patient Information Screen.<br>"
			+"Actual : Verify that the software shall disable the patient Id,First Name, last name, DOB and gender fields which are retrieved from MWL server in patient info screen after selecting a patient from MWL server and also disable PACS button in Patient Information Screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_068 : Verify that the software shall not validate the required fields for PACS server while exporting a prior case to PACS server")]
[Owner("Gaurav Dhumal")]
public void TC_1136710()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141668 :: Pre-requisite:
1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON and required fields as Patient Name and Patient Id
3. PACS should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141669 :: Launch the SDC4K application and Create a new case from home screen. Verify the message displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141670 :: Click Yes Operator should land on the Patient Info screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141671 :: Enter patient id in the Patient Id field. Patient Id should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141672 :: Navigate to Capture screen. The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141673 :: Capture an image by clicking on the Capture button The image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141674 :: End the case. The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141675 :: Click on the Menu button present on the global task bar All the Menu options should be visible to the operator");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141676 :: Click on the Archived Cases menu option The operator should navigate to the Archived Cases screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141677 :: Select the case created above which is having missing patient name by selecting the checkbox prior to it. The case should get selected successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141678 :: Click on the Export button The operator should navigate to the Export screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141679 :: Select Dicom export option and deselect all the other options and click on the Export button The Dicom export option should get selected and the export process should get initiated");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141680 :: Verify the export operation should complete successfully The SDC4K application should save the archived case with missing patient name (required field for dicom export) on the Dicom server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall not validate the required fields for PACS server while exporting a prior case to PACS server<br>"
			+"Actual : Verify that the software shall not validate the required fields for PACS server while exporting a prior case to PACS server");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_069 : To verify that the software shall support retrieval of Studies with Patient Root query.")]
[Owner("Gaurav Dhumal")]
public void TC_1135687()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141681 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Select Retrieve Level as Patient on Dicom server settings. A case having few Images and Videos should be available for retrieval. Pre-conditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141682 :: Create a New Case by pressing Start Case Button from Home Screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141683 :: On Patient Info screen Press Search from PACS. It should display the Import from PACS Screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141684 :: Enter search criteria, select Date Range and Modality as All. Press on Search studies button. Patient List should be displayed matching the specified Search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141685 :: Select any Patient ID and Press on search studies button. Studies should be retrieved successfully using Retrieve Level as Patient.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall support retrieval of Studies with Patient Root query.<br>"
			+"Actual : To verify that the software shall support retrieval of Studies with Patient Root query.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_070 : To verify that the software shall support retrieval of Studies with Study Root query.")]
[Owner("Gaurav Dhumal")]
public void TC_1135686()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141686 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Select Retrieve Level as Study on Dicom server settings. A case having few Images and Videos should be available for retrieval. Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141687 :: Create a New Case by pressing Start Case Button from Home Screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141688 :: On Patient Info screen, click on Search PACS button. Import from PACS Screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141689 :: Enter Search criteria, select Date Range and Modality as All. press on Search button. Patient List should be displayed matching the specified Search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141690 :: Select any Patient ID and press on Search Studies button. Studies should be retrieved successfully using Retrieve Level as Study.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall support retrieval of Studies with Study Root query.<br>"
			+"Actual : To verify that the software shall support retrieval of Studies with Study Root query.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_071 : To verify that the software shall support retrieval of Series with Patient Root query.")]
[Owner("Gaurav Dhumal")]
public void TC_1135689()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141691 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Patient Search Should be selected as PACS in settings.
4. Select Retrieve Level as Patient on Dicom server settings. A case having few Images and Videos should be available for retrieval. Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141692 :: Create a New Case by pressing Start Case Button from Home Screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141693 :: On Patient Info screen, click on Search PACS button. Import from PACS Screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141695 :: Enter the Valid Patient ID,Select Date Range and Modality as All and Press on Search button. Patient List should be displayed matching the specified Search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141696 :: Select any Patient and press on Search studies button. Studies list should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141697 :: From Study list, Verify that series should also be displayed as the child nodes of a specific study. Select any series and Press on Import Patient Details button. User should be able to select study and series.
Series list should be retrieved successfully and Patient Info screen should get filled up with the info of the patient selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall support retrieval of Series with Patient Root query.<br>"
			+"Actual : To verify that the software shall support retrieval of Series with Patient Root query.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_072 : Verify that it is not allowed the user to do PACS Search operation once a patient is selected from MWL server and until user creates new case.")]
[Owner("Gaurav Dhumal")]
public void TC_1135750()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141698 :: Pre-Condition:
1. SDC4K Application Should be running.
2. A valid DICOM server should be configured.
3. Patient Search should be selected as PACS in Application settings.
4.Case record should be available on the Dicom server. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141699 :: Create a New Case. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141700 :: On Patient Info screen, click on Search PACS button. Import from PACS Screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141701 :: Enter search criteria on the Import from Pacs screen. The Search criteria should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141702 :: Click on the search button. Search result should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141703 :: Select the Patient context and press on the Import Patient Details button. The selected Patient details should be added into Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141704 :: Observe the state of Search PACS button. The state of the button should be disabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141705 :: End the current case and again Start a New Case Current case should end successfully. New case should be created and user should be navigated to Patient Info Screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141706 :: Observe the state of Search PACS button. The state of the button should be enabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that it is not allowed the user to do PACS Search operation once a patient is selected from MWL server and until user creates new case.<br>"
			+"Actual : Verify that it is not allowed the user to do PACS Search operation once a patient is selected from MWL server and until user creates new case.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_073 : Verify that the software be able to convert the images retrieved from the DICOM server to 24 bit BMP. It will not use the Image format conversion setting for the same. The converted images shall be given to the system for displaying on the GUI")]
[Owner("Gaurav Dhumal")]
public void TC_1135620()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141707 :: Pre-requisite: 1. Task Manager should already be open using the Task Manager Dongle.
2. SDC4K application should be installed and running
3. A valid DICOM server should be configured on the SDC4K application
4. PACS export option should be checked under Export Settings
5. A case should exist for a particular Patient Id on the DICOM server with DICOM images in it
6. Image Capture Format should be set to BMP. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141708 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141709 :: Navigate to the Home Page and click on the Start Case button New case should be started.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141710 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141711 :: Enter search criteria (Case having DICOM images) and click on the search button, verify that the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141712 :: Select the patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141713 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should display all the imported images on the Import Images/Videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141714 :: Select all the images and click on Add to Album button to add the retrieved images to the Media Gallery of the current case All the images should be added to the Media Gallery of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141715 :: Navigate to the Capture screen. The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141716 :: Capture an image by clicking the Capture button The image should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141717 :: End the current case. The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141718 :: Navigate to the Case Folder within the E:\Data folder and observe the format of the DICOM Images being saved Two copies of each retrieved DICOM Image should be saved in the case folder, one should be in DCM format and other should be in BMP format");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software be able to convert the images retrieved from the DICOM server to 24 bit BMP. It will not use the Image format conversion setting for the same. The converted images shall be given to the system for displaying on the GUI<br>"
			+"Actual : Verify that the software be able to convert the images retrieved from the DICOM server to 24 bit BMP. It will not use the Image format conversion setting for the same. The converted images shall be given to the system for displaying on the GUI");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_074 : Verify that software shall upload the DICOM global settings if user selects yes on the confirmation box which is displayed on click of upload on cloud integration set up screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1136709()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141719 :: Pre - Conditions :
1. SDC4K application must be up and running with network connected.
2. Cloud integration should be confirgured.
3. DICOM should be installed and configured. Pre-conditions must be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141720 :: Navigate to Menu > Settings > Server > Cloud Integration tab and verify that cloud integration setup screen should be displayed. Cloud integration setup screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141721 :: Verify that cloud integration should be saved and ON. Cloud integration should be ON.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141722 :: From the cloud integration setup screen verify that Upload to cloud button should be displayed. Upload to cloud button should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141723 :: Click on Upload to cloud button and then confirm (OK/yes) from the confirmation box to upload global settings to cloud. Global settings should be uploaded to cloud.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141724 :: Login to the Web Application with the same Sales Rep and observe the DICOM Global settings for the same Customer/Group. Uploaded global settings should be shown on the webapp against the same customer/group.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that software shall upload the DICOM global settings if user selects yes on the confirmation box which is displayed on click of upload on cloud integration set up screen.<br>"
			+"Actual : Verify that software shall upload the DICOM global settings if user selects yes on the confirmation box which is displayed on click of upload on cloud integration set up screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_075 : Verify that the software shall support displaying of individual images (along with all the patient information) on the OSD, when the Display button is pressed from Media Gallery")]
[Owner("Gaurav Dhumal")]
public void TC_1136280()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141725 :: Pre-requisite: 1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images in it.
4. OSD monitor should be connected to the SDC4K machine.
5.Show device information on display checkbox should be checked under Display Output settings. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141726 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141727 :: Click on the Search PACS button from the Patient Info screen The Import from PACS
window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141728 :: Enter a search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141729 :: Verify all the search results are populating as per the search criteria. The application should search and display all the patient details as per the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141731 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding images count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141732 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141733 :: Select all the images and click on Add to Album button to add the retrieved images to the Media Gallery of the current case. All the images should be added to the Media Gallery of the current case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141734 :: Navigate to Media Gallery screen. The operator should navigate to the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141735 :: Select any particular image retrieved from the DICOM server and click on Display button (Monitor button). The image should get selected successfully and should be displayed on the connected OSD monitor with all the patient information displayed on the OSD.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall support displaying of individual images (along with all the patient information) on the OSD, when the Display button is pressed from Media Gallery<br>"
			+"Actual : Verify that the software shall support displaying of individual images (along with all the patient information) on the OSD, when the Display button is pressed from Media Gallery");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_076 : Verify that the DICOM album provide support for adding additional 100 images apart from the captured during the current case")]
[Owner("Gaurav Dhumal")]
public void TC_1136272()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141736 :: Pre-requisite: 1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3. A case should exist for a particular Patient Id on the DICOM server with 100 DICOM images in it. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141737 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141738 :: Click on the Search PACS button from the Patient Info screen. The Import from PACS window should be launched successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141739 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141740 :: Verify all the search results are populating as per the search criteria. The application should search and display all the patient details as per the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141741 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141742 :: Select a series having 100 DICOM images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141743 :: Select all the 100 images and click on Add to Album button to add the retrieved images to the DICOM album of the current case All the 100 images should be added to the DICOM album of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141744 :: Navigate to the Capture screen and capture 100 images by clicking the Capture button 100 times The operator should navigate to the Capture screen and 100 images should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141745 :: Navigate Media gallery and check for the images under the Images tab All the 200 images should be displayed in Images tab (Including captured Images and DICOM Images)");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the DICOM album provide support for adding additional 100 images apart from the captured during the current case<br>"
			+"Actual : Verify that the DICOM album provide support for adding additional 100 images apart from the captured during the current case");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_077 : Verify that the software support playback of DICOM retrieved videos")]
[Owner("Gaurav Dhumal")]
public void TC_1136333()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141746 :: Pre-requisite:
1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server with DICOM videos in it
4. OSD monitor should be connected to the SDC4K machine
5.Show Device Information on display should be checked/selected on the Display output setting. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141747 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141748 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141749 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141750 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141751 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding images/videos count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141752 :: Select a series having videos in it and click on the Import Images/Videos button. The application should start the video import process and should retrieve and display all the imported videos on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141753 :: Select all the videos and click on Add to Album button to add the retrieved videos to the Media Gallery of the current case All the videos should be added to the Media Gallery of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141754 :: Navigate to Media Gallery > Videos tab screen The operator should navigate to the Media Gallery > Videos tab screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141755 :: Select any particular video retrieved from the DICOM server and click on the Playback button. The play button and the dropdown should become visible with respect to the selected video.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141756 :: Select appropriate OSD output from dropdown and click on Play button The video should be played back on the connected OSD");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support playback of DICOM retrieved videos<br>"
			+"Actual : Verify that the software support playback of DICOM retrieved videos");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_078 : Verify that the software be able to display progress while the images are being retrieved from DICOM in case of C-Move and C-Get. Also verify the software shall display a progress bar with cancel button when clicked on Import Images/Videos button.")]
[Owner("Gaurav Dhumal")]
public void TC_1135640()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141757 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application
4. Set Retrieve Method as C-Get from Dicom setting. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141758 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141759 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141760 :: Enter search criteria and click on the Search Studies button The application should start searching the search results (Patient / Study / Series) based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141761 :: Select any particular series having images in it and click on the Import Images/Videos button. The application should show a progress bar with Cancel button while the image/video retrieval process is going on.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141762 :: Repeat the steps above for Retrieve Method as C-Move operation also. (A server supporting C-Move operation should also be configured and selected for this) The application should show a progress bar with Cancel button while the image/video retrieval process is going on.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software be able to display progress while the images are being retrieved from DICOM in case of C-Move and C-Get. Also verify the software shall display a progress bar with cancel button when clicked on Import Images/Videos button.<br>"
			+"Actual : Verify that the software be able to display progress while the images are being retrieved from DICOM in case of C-Move and C-Get. Also verify the software shall display a progress bar with cancel button when clicked on Import Images/Videos button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_079 : To verify that the software shall display status messages "Retrieving Images and Videos" while retrieving images and Videos from DICOM server.")]
[Owner("Gaurav Dhumal")]
public void TC_1135666()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141763 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed and configured.
3. DICOM Video should be ON and A case having few Images and Videos should be available for retrieval. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141764 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141765 :: Verify the Do you want to save videos to PACS? popup message should be displayed with yes and no button. The Do you want to save videos to PACS? popup message with yes and no button should be coming on the SDC4K application GUI as the DICOM Video setting is ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141767 :: Click on Yes button, verify pop message should be closed and user should be navigated to patient info screen. User should be navigated to Patient info screen and pop up message should be closed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141768 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141769 :: Enter the search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141770 :: Select any Patient Id and click on the Search Studies button. Select any Study ID > Series ID (which has images and videos in it) and then Retrieve Images and Videos The Retrieval process should be started.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141771 :: Observe the Information Message displayed on the Status bar while Retrieval is in progress. An Information message Retrieving Images and Videos should be displayed during the retrieval process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall display status messages "Retrieving Images and Videos" while retrieving images and Videos from DICOM server.<br>"
			+"Actual : To verify that the software shall display status messages "Retrieving Images and Videos" while retrieving images and Videos from DICOM server.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_080 : Verify that the software be able perform MWL find based on Patient ID")]
[Owner("Gaurav Dhumal")]
public void TC_1135613()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141772 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141773 :: Launch the SDC4K application and start a new case. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141774 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141775 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, First Name Station and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141776 :: Enter any valid and existing Patient Id in the Patient Id text field. For e.g. 2333 and set the date range as ALL/Today as per the search criteria. The value should be entered as 2333 in the Patient Id text field");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141777 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141778 :: Verify all the search results are populating as per the search criteria where the Patient Id is set as 2333 The application should search and display all the patient details which is having Patient Id as 2333");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software be able perform MWL find based on Patient ID<br>"
			+"Actual : Verify that the software be able perform MWL find based on Patient ID");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_081 : Verify that the software search for list of all the patients on MWL server if all the search parameters are left empty(*) for MWL search.")]
[Owner("Gaurav Dhumal")]
public void TC_1135614()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141779 :: Precondition :
1) SDC4K application should be up and running
2) Dicom package should be activated and dicom server that supports MWL search, should be configured Pre Condition should be satisfied");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141780 :: Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141781 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141782 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141783 :: Click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141784 :: Verify all the search results are populating as per the search criteria where the First Name, Station, Last Name and Patient Id fields are empty(*) The application should search and display all the patient details as per the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141785 :: Make the First Name,Station, Last Name and Patient Id fields empty(*) and Select date range as ALL. The First Name, Last Name and Patient Id fields should be empty and date range should be selected as ALL");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141786 :: Click on the Search button The application should search and display all the patient details as per the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software search for list of all the patients on MWL server if all the search parameters are left empty(*) for MWL search.<br>"
			+"Actual : Verify that the software search for list of all the patients on MWL server if all the search parameters are left empty(*) for MWL search.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_082 : Verify that the first step of MWL Find shall display a list of patients matching the search criteria")]
[Owner("Gaurav Dhumal")]
public void TC_1135615()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141787 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141788 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141789 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141790 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141791 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141792 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the first step of MWL Find shall display a list of patients matching the search criteria<br>"
			+"Actual : Verify that the first step of MWL Find shall display a list of patients matching the search criteria");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_083 : Verify that the second step of MWL Find shall display a list of studies matching the selected patient ID")]
[Owner("Gaurav Dhumal")]
public void TC_1135622()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141793 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141794 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141795 :: Click on PACS button. Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141796 :: enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141797 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141798 :: Select any patient id and click on the Search Studies button The application should display the list of all the studies matching the selected Patient Id along with the series and asset information");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the second step of MWL Find shall display a list of studies matching the selected patient ID<br>"
			+"Actual : Verify that the second step of MWL Find shall display a list of studies matching the selected patient ID");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_084 : Verify that the software shall display Search(search MWL), Studies(search studies) enable by default and also allow the operator to cancel the MWL Find operation, at any step.")]
[Owner("Gaurav Dhumal")]
public void TC_1135625()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141799 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141801 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141802 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141803 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141804 :: Verify state of Search and Search Studies button. Search and Studies button should be enabled by default");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141805 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141806 :: When the search operation is in progress, a progress bar with Cancel button is displayed. A Progress bar and cancel button is displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141807 :: Click on the Cancel button. The Search operation will be canceled successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display Search(search MWL), Studies(search studies) enable by default and also allow the operator to cancel the MWL Find operation, at any step.<br>"
			+"Actual : Verify that the software shall display Search(search MWL), Studies(search studies) enable by default and also allow the operator to cancel the MWL Find operation, at any step.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_085 : Verify that the software support selection of images and videos from prior cases and sending it to Media Gallery for further reference during case . Also software displays Retrieving Images and videos... message during retrieval process.")]
[Owner("Gaurav Dhumal")]
public void TC_1135623()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141808 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. DICOM package should be installed.
3. A valid DICOM server should be configured on the SDC4K application. 4. DICOM video should be in On state. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141809 :: Navigate to Home screen and press on the Start Case button. Upon creation of a new case, a pop-up message Do you want to save videos to PACS? should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141810 :: Click on Yes button on the pop-up message. The pop-up message should go off and patient info screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141811 :: Click on the Search PACS button from the Patient Info screen. The Import from PACS window should be launched successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141812 :: Enter a search criteria and click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141813 :: Verify all the search results are populating as per the search criteria. The application should search and display all the patient details as per the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141814 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141815 :: Select a series having images and Videos in it and click on the Import Images/Videos button. The application should start the image import process and display Retrieving Images and Videos message in global task bar.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141816 :: Verify all the images and videos retrieved from the dicom server should be displayed on the Import Images/Videos screen. All the images and videos retrieved should be displayed on the Import Images/videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141817 :: Verify user can select/deselect the retrieved images and videos by clicking on it. User should be able to select and deselect the retrieved media(images/videos) after completion retrieval process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141818 :: Select media to retrieve and click on Add to Album button to send the retrieved images/videos to the Media Gallery of the current case. Images and Videos should be send to the Media Gallery of the current case. The operator should land back on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141819 :: Navigate to the Media Gallery screen and check for the imported images and videos. All the imported images and videos should be displayed under All tab of the Media Gallery.
Images should be present under the Images tab and videos should be present under the Videos tab.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support selection of images and videos from prior cases and sending it to Media Gallery for further reference during case . Also software displays Retrieving Images and videos... message during retrieval process.<br>"
			+"Actual : Verify that the software support selection of images and videos from prior cases and sending it to Media Gallery for further reference during case . Also software displays Retrieving Images and videos... message during retrieval process.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_086 : Verify that the software provide conversion of the DCM files into BMP format that can be used to display on the system")]
[Owner("Gaurav Dhumal")]
public void TC_1135629()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141820 :: Pre-requisite: 1. Task Manager should already be open using the Task Manager Dongle. 2. SDC4K application should be installed and running 3. DICOM package should be installed. 4. A valid DICOM server should be configured on the SDC4K application
5.Image capture format should be set to BMP. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141821 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141822 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141823 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141824 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141825 :: Select any patient id and click on the Search Studies button The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141826 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141827 :: Click on Add to Album button to add the retrieved images to the Media Gallery of the current case. Images should be added to the Media Gallery of the current case and the operator should land back on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141828 :: Navigate to the Media Gallery screen and check for the imported images in the Images tab. All the imported images should be displayed in Images tab of the Media Gallery.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141829 :: Navigate to current case folder in SDC4K local drive at E:\Data and check for the imported images in the BMP format. All the imported images should be present in the BMP format in the case folder.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software provide conversion of the DCM files into BMP format that can be used to display on the system<br>"
			+"Actual : Verify that the software provide conversion of the DCM files into BMP format that can be used to display on the system");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_087 : Verify that the software support retrieval of prior cases from the DICOM server for a specific study")]
[Owner("Gaurav Dhumal")]
public void TC_1135634()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141830 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed.
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141831 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141832 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141833 :: enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141834 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141835 :: Select any patient id and click on the Search Studies button Studies list should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141837 :: From Study list, Verify that series should also be displayed as the child nodes of a specific study. Select any series from a specific study. Click on Import Patient details button. User should be able to select any series from a specific study. Patient Info screen should get filled up with the info of the patient(study) selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support retrieval of prior cases from the DICOM server for a specific study<br>"
			+"Actual : Verify that the software support retrieval of prior cases from the DICOM server for a specific study");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_088 : Verify that the software support retrieval of images from the DICOM server using C-Move service either with Patient Root query or Study Query.")]
[Owner("Gaurav Dhumal")]
public void TC_1135632()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141838 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed.
3. A valid DICOM server should be configured on the SDC4K application with Retrieval Method as C-Move and Retrieve Level to be Patient. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141839 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141840 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141841 :: Enter search criteria and Click on the Search studies button The search should get initiated and the results should be populated based upon the current search criteria. Under every study, the available series should be present with information regarding assets count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141842 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141843 :: Select a series having images in it and click on the Import Images/Videos button. System Should display the retrieved images .");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141844 :: Select all the images and click on the Add to Album button. Images should be added to the Media Gallery of the current case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141845 :: Repeat the above steps for Retrieve Level to be Study. Image Retrieval should be successful for C-Move with Retrieval Level to be Study.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support retrieval of images from the DICOM server using C-Move service either with Patient Root query or Study Query.<br>"
			+"Actual : Verify that the software support retrieval of images from the DICOM server using C-Move service either with Patient Root query or Study Query.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_089 : Verify that the software support retrieval of images from the DICOM server using C-Get service")]
[Owner("Gaurav Dhumal")]
public void TC_1135647()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141846 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed.
3. A valid DICOM server should be configured on the SDC4K application with Retrieval Method as C-Get and Retrieve Level to be Patient. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141847 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141848 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141849 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141850 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141851 :: Select any patient id and click on the Search Studies button The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141852 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141853 :: Select all the images and click on the Add to Album button. Images should be added to the Media Gallery of the current case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141854 :: Repeat the above steps for Retrieve Level to be Study Image Retrieval should be successful for C-Get with Retrieval Level to be Study.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support retrieval of images from the DICOM server using C-Get service<br>"
			+"Actual : Verify that the software support retrieval of images from the DICOM server using C-Get service");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_090 : Verify that application display information message Adding Image(s) and Adding video(s) when user clicks on 'Add to Album' button.")]
[Owner("Gaurav Dhumal")]
public void TC_1135577()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141855 :: Preconditions:
1. Launch the application.
2. DICOM package should be activated and the DICOM settings should be configured.
3.Channel Mode should be Single. Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141856 :: Login to SDC4K device and navigate to Settings > Server > DICOM > Settings. DICOM Settings screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141857 :: Enable the DICOM Video option by pressing its toggle button. DICOM Video option should be turned ON. Message DICOM Video settings will take effect upon creation of new case should be displayed in the status bar at the bottom of the screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141858 :: Navigate to Home screen and press on the Start Case button. Upon creation of a new case, a pop-up message Do you want to save videos to PACS? should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141859 :: Click on Yes button on the pop-up message. The pop-up message should go off and patient info screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141861 :: Enter patient id of case for which videos and images exist on PACS server and press each PACS button. Import from PACS screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141862 :: Change the Date Range field to All and press Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141863 :: Retrieve all Images and Videos associated with the case. Retrieval process should be completed and all Images/Videos should be successfully retrieved.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141864 :: Select and Images and Videos thumbnails and click on the Add to Album button. Adding Image(s) and Adding video(s) message should be displayed on the status bar on the bottom of the screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that application display information message Adding Image(s) and Adding video(s) when user clicks on 'Add to Album' button.<br>"
			+"Actual : Verify that application display information message Adding Image(s) and Adding video(s) when user clicks on 'Add to Album' button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_091 : To verify that the software shall display status messages "Retrieving Images" while retrieving images from DICOM server.")]
[Owner("Gaurav Dhumal")]
public void TC_1135667()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141865 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed and configured.
3. DICOM Video should be OFF and A case having few Images should be available for retrieval. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141866 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141867 :: Click on the Search PACS button from the Patient Info screen The Search PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141868 :: Enter search criteria and Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141869 :: Select any Patient id and click on Search Studies button. Select any Series and then Retrieve Images. The Retrieval process should be started.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141870 :: Observe the Information Message displayed on the Status bar while Retrieval is in progress. An Information message Retrieving Images should be displayed during the retrieval process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall display status messages "Retrieving Images" while retrieving images from DICOM server.<br>"
			+"Actual : To verify that the software shall display status messages "Retrieving Images" while retrieving images from DICOM server.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_092 : Verify assets selection and deselection, message on click of Add to album button and patient information screen should be displayed when user on click on add to album button.")]
[Owner("Gaurav Dhumal")]
public void TC_1135619()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141871 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. DICOM package should be installed.
3. A valid DICOM server should be configured on the SDC4K application.
4.DICOM Video should be OFF and a case having few Images should be available for retrieval. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141872 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141873 :: Click on search pacs button on patient info screen. Import from PACS screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141874 :: Select Data Range as ALL, enter search criteria and Click Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141875 :: Select any patient id and click on the Search Studies button. The application should display the list of studies under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141876 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141877 :: Verify all assets are selected after retrieval process is completed By Default system should select all assets on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141878 :: Verify select /deselect option for one or all assets System should allow user to select /deselect one or all assets by clicking on assets");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141879 :: Now close the screen and again select any series with images in it and click import images/videos The application should start the image import process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141880 :: Select all images and click on Add to album button Adding image(s) message should be displayed in global task bar and Patient information screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify assets selection and deselection, message on click of Add to album button and patient information screen should be displayed when user on click on add to album button.<br>"
			+"Actual : Verify assets selection and deselection, message on click of Add to album button and patient information screen should be displayed when user on click on add to album button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_093 : Verify that the software support retrieval of images and videos from PACS server")]
[Owner("Gaurav Dhumal")]
public void TC_1135618()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141882 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM/PACS server should be configured on the SDC4K application with Dicom Video set to ON.
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images and videos in it. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141883 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141884 :: Verify the Do you want to save videos to PACS? popup message should be displayed with yes and no button. The Do you want to save videos to PACS? popup message with yes and no button should be coming on the SDC4K application GUI as the DICOM Video setting is ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141885 :: Click on Yes button, verify pop message should be closed and user should be navigated to patient info screen. User should be navigated to Patient info screen and pop up message should be closed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141886 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141887 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141888 :: Enter search criteria and Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141889 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141890 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141891 :: Select a series having images and videos in it, click on the Import Images/Videos button. The application should start the import process and should retrieve and display all the imported media on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support retrieval of images and videos from PACS server<br>"
			+"Actual : Verify that the software support retrieval of images and videos from PACS server");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_094 : Verify that the software allow the operator to cancel the retrieval operation of images and videos from PACS server")]
[Owner("Gaurav Dhumal")]
public void TC_1135653()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141892 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM/PACS server should be configured on the SDC4K application with Dicom Video set to ON.
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images and videos in it Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141893 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141895 :: Verify the Do you want to save videos to PACS? popup message should be displayed with yes and no button. The Do you want to save videos to PACS? popup message with yes and no button should be coming on the SDC4K application GUI as the DICOM Video setting is ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141896 :: Click on Yes button, verify pop message should be closed and user should be navigated to patient info screen. User should be navigated to Patient info screen and pop up message should be closed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141897 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141898 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station,First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141899 :: Enter search criteria and Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141900 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141901 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141902 :: Select a series having images and videos in it, click on the Import Images/Videos button. The application should start the import process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141903 :: Click on the Cancel button while the Images and Videos are being retrieved from the DICOM server The retrieving operation of Images/Videos should be cancelled successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software allow the operator to cancel the retrieval operation of images and videos from PACS server<br>"
			+"Actual : Verify that the software allow the operator to cancel the retrieval operation of images and videos from PACS server");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_095 : Verify that the software wait indefinitely for the retrieval of images and videos from the PACS server unless the operation is canceled by user input")]
[Owner("Gaurav Dhumal")]
public void TC_1135642()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141904 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM/PACS server should be configured on the SDC4K application.
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images/videos in it. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141905 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141906 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141908 :: Verify the search criteria fields present on the Import from PACS window The Patient Id, Station, First Name and Last Name fields should have * in them. The Date Range drop down field should have Today value as pre-selected. The Modality drop down should have ALL value as pre-selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141909 :: Enter search criteria and Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141910 :: Verify all the search results are populating as per the search criteria The application should search and display all the patient details as per the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141911 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141912 :: Select a series having asset in it and click on the Import Images/Videos button. The application should start the import process.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141913 :: Verify that the software display a progress bar and cancel button for the images/videos to be retrieved from the DICOM server The SDC4K application should display a progress bar and cancel button until all the images/videos retrieved from the DICOM server");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141914 :: Remove the network cable while retrieval is in process. The progress bar and cancel button would remain as it is on the screen unless the operation has been canceled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software wait indefinitely for the retrieval of images and videos from the PACS server unless the operation is canceled by user input<br>"
			+"Actual : Verify that the software wait indefinitely for the retrieval of images and videos from the PACS server unless the operation is canceled by user input");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_096 : Verify that the naming convention for DICOM image is "DCM_image_xxx.bmp" where xxx is from 001 to 100")]
[Owner("Gaurav Dhumal")]
public void TC_1135636()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141915 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server with 100 DICOM images in it
4. USB drive should be connected to the SDC4K machine
5.Encryption should be OFF. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141916 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141917 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141918 :: Enter the Patient Id in the Patient Id field which is having 100 DICOM images in its existing case. Select Date Range as ALL and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141919 :: Select any patient id and click on the Search Studies button The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141920 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141921 :: Click on Add to Album button to add the retrieved images to the Media Gallery of the current case Images should be added to the Media Gallery of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141922 :: Navigate to the Media Gallery screen and check for the images in the Images tab All the imported images should be displayed in Images tab of the Media Gallery");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141923 :: Select all the images imported from the DICOM server All the images imported from the DICOM server should get selected successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141924 :: Click on the Export button The operator should navigate to the Export screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141925 :: Select only USB option and deselect all the other options The USB option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141926 :: Click on the Export button to save the case to connected USB drive Case should be successfully saved into the connected flash drive");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141927 :: Open the USB drive on a computer and look at the file names DICOM Images should be named as i.e. DCM_image_xxx.bmp. (xxx is the number of images) where xxx is from 001 to 100");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the naming convention for DICOM image is "DCM_image_xxx.bmp" where xxx is from 001 to 100<br>"
			+"Actual : Verify that the naming convention for DICOM image is "DCM_image_xxx.bmp" where xxx is from 001 to 100");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_097 : Verify that the system allow adding maximum of 100 DICOM images to a current case")]
[Owner("Gaurav Dhumal")]
public void TC_1135656()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141928 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. A case should exist for a particular Patient Id on the DICOM server with 100 DICOM images in it Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141930 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141931 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141932 :: Enter the Patient Id in the Patient Id field which is having 100 DICOM images in its existing case. Select Date Range as ALL and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141933 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141934 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141935 :: Click on Add to Album button to add the retrieved images to the Medial Gallery of the current case All the 100 images should be added to the Media Gallery of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141936 :: Navigate to the Capture screen under heading and capture 3 images by clicking the Capture button Image should be captured successfully apart from the 100 images retrieved from the DICOM server");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141937 :: Navigate to the Media Gallery screen and check for the images in the Images tab The Media Gallery screen should be having all the images which are captured through the Capture screen and the images retrieved from the DICOM server");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system allow adding maximum of 100 DICOM images to a current case<br>"
			+"Actual : Verify that the system allow adding maximum of 100 DICOM images to a current case");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_098 : Verify that the system allow adding maximum of 99 DICOM videos to a current case.")]
[Owner("Gaurav Dhumal")]
public void TC_1135654()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141938 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON
3. A case should exist for a particular Patient Id on the DICOM server with 99 DICOM videos in it Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141939 :: Navigate to Home screen and press on the Start Case button. Upon creation of a new case, a pop-up message Do you want to save videos to PACS? should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141940 :: Click on Yes button on the pop-up message. The pop-up message should go off and patient info screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141941 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141942 :: Enter the Patient Id in the Patient Id field which is having 99 DICOM videos in its existing case. Select Date Range as ALL and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141943 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141944 :: Select a series having 99 videos in it and import it. The application should start the image/video import process and should retrieve and display all the imported videos on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141945 :: Click on Add to Album button to add the retrieved videos to the Medial Gallery of the current case All the 99 videos should be added to the Media Gallery of the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141946 :: Navigate to the Capture screen and record 3 videos by clicking the Record button The videos should be recorded successfully apart from the 99 videos retrieved from the DICOM server");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141947 :: Navigate to the Media Gallery screen and check for the videos in the videos tab. The Media Gallery screen should be having all the videos which are recorded through the Capture screen and the videos retrieved from the DICOM server");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system allow adding maximum of 99 DICOM videos to a current case.<br>"
			+"Actual : Verify that the system allow adding maximum of 99 DICOM videos to a current case.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_099 : To verify that the software shall remove the asterisk (*) from the specific field when clicked.")]
[Owner("Gaurav Dhumal")]
public void TC_1135692()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141949 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed and configured. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141950 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141951 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141952 :: Tap on any specific field where Asterisk (*) is displayed. The Asterisk (*) character should be removed from the specific field when user clicks/taps on that field.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141953 :: Do not enter any value and tap somewhere else. The Asterisk (*) character should be displayed again on that specific field.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that the software shall remove the asterisk (*) from the specific field when clicked.<br>"
			+"Actual : To verify that the software shall remove the asterisk (*) from the specific field when clicked.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_100 : Verify that the software display generic thumbnail image for all DICOM retrieved videos")]
[Owner("Gaurav Dhumal")]
public void TC_1135631()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141954 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON
3. A case should exist for a particular Patient Id on the DICOM server with DICOM videos in it Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141955 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141956 :: Verify the Do you want to save videos to PACS? popup message should be displayed with yes and no button. The Do you want to save videos to PACS? popup message with yes and no button should be coming on the SDC4K application GUI as the DICOM Video setting is ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141957 :: Click on Yes button, verify pop message should be closed and user should be navigated to patient info screen. User should be navigated to Patient info screen and pop up message should be closed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141958 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141959 :: Enter the search criteria (which is having DICOM videos in its existing case record) and click on the Search Studies button. The application should display the list of studies based upon the current search criteria. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141960 :: Select a series having videos in it and click on the Import Images/Videos button. The application should start the video import process and should retrieve and display all the imported videos on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141961 :: Verify the generic thumbnail on the retrieved DICOM videos Generic thumbnail should be present on each and very DICOM retrieved video");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software display generic thumbnail image for all DICOM retrieved videos<br>"
			+"Actual : Verify that the software display generic thumbnail image for all DICOM retrieved videos");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_101 : Verify that the system shall by default, disable the : Import Images/Videos button on the DICOM screen.")]
[Owner("Gaurav Dhumal")]
public void TC_1135617()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141962 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3.PACS should be selected under Patient search in the Application setting. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141963 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141964 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141965 :: Verify the state of the Import Images/Videos button. The Import Images/Videos button should be in disabled state.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141966 :: Close the Import from PACS screen by clicking on the X button. The Import from PACS screen should be closed and the operator should redirected to the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141967 :: Navigate to SDC4K Home screen by ending the above case, click on Patients. The operator should be directed to the Patients screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141968 :: Click on the Search PACS button present under the New Patient section. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141969 :: Verify the state of the Import Images/Videos button. The Import Images/Videos button should be in disabled state.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall by default, disable the : Import Images/Videos button on the DICOM screen.<br>"
			+"Actual : Verify that the system shall by default, disable the : Import Images/Videos button on the DICOM screen.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_102 : Verify that the system shall display a progress bar and a Cancel button with text 'Cancel'.")]
[Owner("Gaurav Dhumal")]
public void TC_1135650()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141971 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141972 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141973 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141974 :: Enter search criteria and click on the Search button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141975 :: Verify a search progress bar and a Cancel button with text Cancel is displayed on the Import from PACS screen. The search progress bar and a Cancel button with text Cancel is displayed on the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display a progress bar and a Cancel button with text 'Cancel'.<br>"
			+"Actual : Verify that the system shall display a progress bar and a Cancel button with text 'Cancel'.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_103 : Verify that the system shall enable the 'Import Images/Videos' button when a series is selected.")]
[Owner("Gaurav Dhumal")]
public void TC_1135637()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141976 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141977 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141978 :: Click on the Start Case button present on the Start Case screen. The operator should be directed to the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141979 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141980 :: Enter the search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141981 :: Verify the state of the Import Images/Videos button. The Import Images/Videos button should be disabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141982 :: Select any Study id and expand the Study by clicking on expander associated to it. The Series list should be displayed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141983 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue background color in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141984 :: Verify the state of the Import Images/Videos button. The Import Images/Videos button should get enable.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall enable the 'Import Images/Videos' button when a series is selected.<br>"
			+"Actual : Verify that the system shall enable the 'Import Images/Videos' button when a series is selected.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_104 : Verify that the system shall only display a close(X) button, add to album, select all, deselect all toggle button along with the progress bar and cancel button when the 'Import Images\Videos' button is clicked.")]
[Owner("Gaurav Dhumal")]
public void TC_1135638()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141986 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141987 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141988 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141989 :: Enter search criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141990 :: Wait for the search to finish and verify the following study information in the records present in the search result grid:
Series Number, followed by number of assets and Modality for each record. After the search operation is finished the operator should see the information in the search records in the following fashion: Series # total Assets: <Asset Count> Modality: ES().");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141991 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue background in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141992 :: Click on the Import Images/Videos button. The application should import the images present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141993 :: Verify when the Import Images/Videos button is clicked, the progress bar appears with a cancel button. Progress Bar should appear with Cancel button on the Import Images/Videos screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141994 :: Verify the presence of Add to Album, Close(X) Select All and Deselect All toggle button when the progress bar disappears from the GUI and the images are imported successfully. The Add to Album, Close(X) Select All and Deselect All toggle button are visible when the progress bar disappears from the GUI and the images imported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall only display a close(X) button, add to album, select all, deselect all toggle button along with the progress bar and cancel button when the 'Import Images\Videos' button is clicked.<br>"
			+"Actual : Verify that the system shall only display a close(X) button, add to album, select all, deselect all toggle button along with the progress bar and cancel button when the 'Import Images\Videos' button is clicked.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_105 : Verify that the system shall display information in numeral while progress bar is loading an item with current loading item / total number of items to be loaded.")]
[Owner("Gaurav Dhumal")]
public void TC_1135644()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141995 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141996 :: Launch the SDC4K application and Create a new case from home screen. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141997 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141998 :: Enter search criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1141999 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142000 :: Click on the Import Images/Videos button. The application should import the images present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142002 :: Verify the progress bar for loading the images from DICOM server. The progress bar should display the information in numeral while progress bar is loading an item with current loading images / total number of images to be loaded.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display information in numeral while progress bar is loading an item with current loading item / total number of items to be loaded.<br>"
			+"Actual : Verify that the system shall display information in numeral while progress bar is loading an item with current loading item / total number of items to be loaded.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_106 : Verify that the system shall display and select all available images and videos for the series, if available.")]
[Owner("Gaurav Dhumal")]
public void TC_1135616()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142003 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3. DICOM Video option should be ON Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142004 :: Launch the SDC4K application and Create a new case from home screen. Verify the Do you want to save videos to PACS? popup message should be displayed with yes and no button. The Do you want to save videos to PACS? popup message with yes and no button should be coming on the SDC4K application GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142005 :: Click on Yes button, verify pop message should be closed and user should be navigated to patient info screen. User should be navigated to Patient info screen and pop up message should be closed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142006 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142007 :: Enter search criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142008 :: Wait for the search to finish and verify the following study information in the records present in the search result grid:
Series Number, followed by number of asset and Modality for each record. After the search operation is finished the operator should see the information in the search records in the following fashion: Series # Total Assets: <Asset Count> Modality: ES().");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142009 :: Click on any of the series to select it from the search results which has images/videos in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142010 :: Click on the Import Images/Videos button. The application should import the images/videos present under the selected series.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142011 :: Wait for the import operation to finish, verify the images/videos should be imported successfully. Also verify all the imported media should be selected. All the imported images/videos should be selected and displayed on Import Images/Videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display and select all available images and videos for the series, if available.<br>"
			+"Actual : Verify that the system shall display and select all available images and videos for the series, if available.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_107 : Verify that the system enable the Add to Album button only if at least one image or video is selected.")]
[Owner("Gaurav Dhumal")]
public void TC_1135648()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142012 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142013 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142014 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142015 :: Enter search criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142016 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142017 :: Click on the Import Images/Videos button. The application should import the images present under the selected series.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142018 :: Wait for the import operation to finish and verify the images which were imported successfully. All the imported images/videos should be displayed on Import Images/Videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142020 :: Unselect all the images and verify the state of the Add to Album button The Add to Album button should be disabled when no image imported from DICOM is selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142021 :: Click on any of the imported image to select it and verify the state of the Add to Album button. The Add to Album button should be enabled when any of the image imported from DICOM is selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142022 :: Click on the Select All button and verify the state of the Add to Album button. The Add to Album button should be enabled when all the images imported from DICOM is selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142023 :: Repeat the above steps by retrieving the Dicom Video from Dicom server(turn Dicom Video ON from Dicom Settings) Result should be same as above.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system enable the Add to Album button only if at least one image or video is selected.<br>"
			+"Actual : Verify that the system enable the Add to Album button only if at least one image or video is selected.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_108 : Verify that the system shall Deselect all the available images or videos when the user clicks on 'Deselect All' button.")]
[Owner("Gaurav Dhumal")]
public void TC_1135655()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142024 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142025 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142026 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142027 :: Enter Search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142028 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142029 :: Click on the Import Images/Videos button. The application should import the images present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142030 :: Wait for the import operation to finish and verify the images which were imported successfully. All the imported images should be imported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142031 :: Verify all the available images should get unselected on the click of the Deselect All button. All the imported images should get un-selected when the operator clicks on the Deselect All button.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall Deselect all the available images or videos when the user clicks on 'Deselect All' button.<br>"
			+"Actual : Verify that the system shall Deselect all the available images or videos when the user clicks on 'Deselect All' button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_109 : Verify that the system shall select all the available images or videos when the user clicks on 'Select All' button.")]
[Owner("Gaurav Dhumal")]
public void TC_1135645()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142032 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142033 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142034 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142035 :: Enter search criteria and Click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142036 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142037 :: Click on the Import Images/Videos button. The application should import the images present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142039 :: Wait for the import operation to finish and verify the images which were imported successfully. All the imported images should be imported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142040 :: Click on the Deselect All button and verify the state of the Add to Album button. All the imported images should get un-selected when the operator clicks on the Deselect All button. Add to album gets disabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142041 :: Click on the Select All button and verify the state of the Add to Album button. All the imported images should get selected when the operator clicks on the Select All button. Add to album gets enabled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall select all the available images or videos when the user clicks on 'Select All' button.<br>"
			+"Actual : Verify that the system shall select all the available images or videos when the user clicks on 'Select All' button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_110 : Verify that the system shall display default dicom search screen when the user clicks on cross button(X).")]
[Owner("Gaurav Dhumal")]
public void TC_1135646()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142042 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142043 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142044 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142045 :: Enter search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142046 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142047 :: Click on the Import Images/Videos button. The application should import the images present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142048 :: Wait for the import operation to finish and verify the images which were imported successfully. All the imported images should be imported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142049 :: Click on the cross button(X) present on the DICOM imported images screen The operator should be re-directed to the default DICOM search screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display default dicom search screen when the user clicks on cross button(X).<br>"
			+"Actual : Verify that the system shall display default dicom search screen when the user clicks on cross button(X).");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_111 : Verify that the system shall also import patient demographic information when the user clicks on Add To Album button.")]
[Owner("Gaurav Dhumal")]
public void TC_1135651()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142050 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142051 :: Launch the SDC4K application and Create a new case from home screen.. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142052 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142053 :: Enter search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142054 :: Click on any of the series to select it from the search results which has images in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142055 :: Click on the Import Images/Videos button. The application should import the images present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142056 :: Wait for the import operation to finish and verify the images which were imported successfully. All the imported images should be imported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142057 :: Select at least one image and click on the Add to Album button. The operator should navigate to the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142058 :: Verify the patient demographic data on the Patient Info screen. The patients demographic data associated with the series selected should get populated in the respective fields on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall also import patient demographic information when the user clicks on Add To Album button.<br>"
			+"Actual : Verify that the system shall also import patient demographic information when the user clicks on Add To Album button.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_112 : Verify that the system shall display imported images, video on Media Gallery screen only.")]
[Owner("Gaurav Dhumal")]
public void TC_1135627()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142059 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3.Dicom Video should be ON. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142060 :: Navigate to Home screen and press on the Start Case button. Upon creation of a new case, a pop-up message Do you want to save videos to PACS? should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142061 :: Click on Yes button on the pop-up message. The pop-up message should go off and patient info screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142062 :: Click on the Search PACS button. The operator should be directed to the Import from PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142064 :: Enter Search criteria and click on the Search Studies button. The application should start searching the search results based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142065 :: Click on any of the series to select it from the search results which has media in it. The selected series should appear highlighted by blue border in the search result grid.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142066 :: Click on the Import Images/Videos button. The application should import the media present under the selected series and display on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142067 :: Wait for the import operation to finish and verify the media which were imported successfully. All the media should be imported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142068 :: Select at least one image and video, click on the Add to Album button. The operator should navigate to the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142069 :: Verify the patient demographic data on the Patient Info screen. The patients demographic data associated with the series selected should get populated in the respective fields on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142070 :: Navigate to the Media Gallery screen and verify the presence of imported images under the Images tab. The imported image should be present under the Images tab of Media Gallery screen and the count on the tab name should be equal to the total number of images present.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142071 :: Navigate to Video tab and verify the presence of imported video. The imported video should be present under the Videos tab");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142072 :: Navigate to All tab, verify the presence of imported image and video. The imported image and video should be present under the All tab.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the system shall display imported images, video on Media Gallery screen only.<br>"
			+"Actual : Verify that the system shall display imported images, video on Media Gallery screen only.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_113 : Verify if user is able to perform MWL find based on Patient First Name.")]
[Owner("Gaurav Dhumal")]
public void TC_1135660()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142073 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Pre-requisites should be met successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142074 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142075 :: Click on the Search PACS button. Import from PACS screen should get displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142076 :: Enter any valid and existing value in Patient First Name text field (for e.g. Rohit). Select Date Range as per the search criteria. The value should be entered in the Patient First Name text field and date Range should be set as per the search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142077 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142078 :: Verify all the search results are populating as per the search criteria where the Patient First Name is set as Rohit The application should search and display all the patient details which is having Patient First Name as Rohit");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify if user is able to perform MWL find based on Patient First Name.<br>"
			+"Actual : Verify if user is able to perform MWL find based on Patient First Name.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_114 : Verify if user is able to perform MWL find based on patient last name.")]
[Owner("Gaurav Dhumal")]
public void TC_1135662()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142079 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Pre-requisites should be met successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142080 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142082 :: Click on the Search PACS button Import from PACS screen should get displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142083 :: Enter any valid and existing value in Patient Last Name text field (for eg. Goel). Select Date Range as per the search criteria. The value should be entered in the Patient Last Name text field and date Range should be set as per the search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142084 :: Click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142085 :: Verify all the search results are populating as per the search criteria where the Patient Last Name is set as Goel The application should search and display all the patient details which is having Patient Last Name as Goel");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify if user is able to perform MWL find based on patient last name.<br>"
			+"Actual : Verify if user is able to perform MWL find based on patient last name.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_115 : Verify and Validate the functionality of displaying a list of series matching the selected Study as third step of MWL find.")]
[Owner("Gaurav Dhumal")]
public void TC_1135658()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142086 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142087 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142088 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142089 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142090 :: Select any patient id and click on the Search Studies button The further Search should be performed and the Study list should be displayed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142091 :: Select any Study id by clicking on expander associated to it. The Series list should be displayed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142092 :: Verify all the search results are populating as per the search criteria The application should display the list of all the Series matching the selected Study along with asset information.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify and Validate the functionality of displaying a list of series matching the selected Study as third step of MWL find.<br>"
			+"Actual : Verify and Validate the functionality of displaying a list of series matching the selected Study as third step of MWL find.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_116 : Verify and Validate the functionality of displaying selected images and videos based on series list as the fourth step of MWL search.")]
[Owner("Gaurav Dhumal")]
public void TC_1135668()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142093 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142094 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142095 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142096 :: Enter Search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142097 :: Select any patient id and click on the Search Studies button The Search should be performed again and the Study list should be displayed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142098 :: Select any Study id and expand the Study by clicking on expander associated to it. The Series list should be displayed now.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142099 :: Verify all the search results are populating as per the search criteria The application should display the list of all the Series matching the selected Study along with asset information.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142100 :: Select any Series row and click on the Import Images/Videos button The images and videos should be displayed on the Import Images/Videos screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify and Validate the functionality of displaying selected images and videos based on series list as the fourth step of MWL search.<br>"
			+"Actual : Verify and Validate the functionality of displaying selected images and videos based on series list as the fourth step of MWL search.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_117 : Verify the software shall display a list of matching Search criteria of Date Range and Modality.")]
[Owner("Gaurav Dhumal")]
public void TC_1135657()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142101 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed
3. A valid DICOM server should be configured on the SDC4K application Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142102 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142104 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142105 :: Enter Search criteria, Set the Date Range and Modality as ALL and press the Search button as per the search criteria. On the screen all the records should be shown irrespective of the Date Range and Modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142106 :: Set the Date Range as Today and Modality as ALL and press the Search or Search Studies button as per the search criteria. On the screen only those records should be shown that were added only today and irrespective of the Modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142107 :: Set the Date Range as Today and Modality as ES and press the Search or Search Studies button as per the search criteria.. On the screen only those records should be shown that were added only today and for which Modality is ES.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142108 :: Set the Date Range as ALL and Modality as ES and press the Search or Search Studies button as per the search criteria. On the screen only those records should be shown for which Modality is ES irrespective of the Date Range.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify the software shall display a list of matching Search criteria of Date Range and Modality.<br>"
			+"Actual : Verify the software shall display a list of matching Search criteria of Date Range and Modality.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_118 : Verify and validate that the software shall display the DICOM image on primary OSD when the user Click on Display button in media gallery.")]
[Owner("Gaurav Dhumal")]
public void TC_1135661()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142109 :: Pre-requisite:-
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application.
3. A case should exist for a particular Patient Id on the DICOM server with DICOM images in it.
4. OSD monitor should be connected to the SDC4K machine.
5.Show device information on display checkbox should be checked under Display Output settings. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142110 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142111 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142112 :: Enter search criteria and click on the Search button The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142113 :: Select any patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142114 :: Select any Study ID > Series ID and then click on Import Images/Videos button Retrieval Process should begin.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142115 :: Add the retrieved images by clicking on add to album button Images should be added successfully to Media Gallery");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142116 :: Navigate to Media Gallery Media Gallery screen should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142117 :: Select any image and click on the Display(Monitor) button. Image should be displayed on the OSD.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify and validate that the software shall display the DICOM image on primary OSD when the user Click on Display button in media gallery.<br>"
			+"Actual : Verify and validate that the software shall display the DICOM image on primary OSD when the user Click on Display button in media gallery.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_119 : Verify the default value of DICOMCANCELTIMEOUT value from configuration file(SDCSettings.xml).")]
[Owner("Gaurav Dhumal")]
public void TC_1135665()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142118 :: Pre-Condition :
1. SDC4K Application should be running.
2. Task Manager should already be open using the Task manager activation dongle. Pre-Condition should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142119 :: Open the explorer window. Explorer window should be successfully opened.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142120 :: Navigate to the location D:\Executables\xml_files and open the SDCSettings.xml file in edit mode. The location D:\Executables\xml_files should be opened and the SDCSettings.xml file should be successfully opened in Edit mode.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142121 :: Locate the configurable Tag DICOMCANCELTIMEOUT and observe its default value. The DICOMCANCELTIMEOUT tag should be present with the default value as 30000 milliseconds.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify the default value of DICOMCANCELTIMEOUT value from configuration file(SDCSettings.xml).<br>"
			+"Actual : Verify the default value of DICOMCANCELTIMEOUT value from configuration file(SDCSettings.xml).");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_120 : Verify that the DICOM Cancel operation is performed within 30 seconds as defined in DICOMCANCELTIMEOUT tag value from configuration file.")]
[Owner("Gaurav Dhumal")]
public void TC_1135664()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142122 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed and configured.
3. Use Calibrated stopwatch for capturing exact time taken Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142123 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142124 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142126 :: Enter search criteria and click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142127 :: Select a record and click on Search Studies . Select any Patient id > Study ID > Series ID and then click on Import Images/Videos button Retrieval Process should begin.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142128 :: Press on the Cancel button to cancel the retrieve operation. When pressing on the Cancel button, status message should be displayed as Operation has been canceled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142129 :: As soon as Cancel button is pressed start stop watch as well , measure the exact time that the system takes to Cancel the DICOM Retrieval operation in stop watch . The DICOM retrieval Cancel operation should take maximum of 30 seconds.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142130 :: Wait till the Cancel operation happens. The application should not hang and the retrieval operation should be successfully cancelled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the DICOM Cancel operation is performed within 30 seconds as defined in DICOMCANCELTIMEOUT tag value from configuration file.<br>"
			+"Actual : Verify that the DICOM Cancel operation is performed within 30 seconds as defined in DICOMCANCELTIMEOUT tag value from configuration file.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_121 : Software shall display "Operation has been canceled." message on the status bar during DICOM cancel operation.")]
[Owner("Gaurav Dhumal")]
public void TC_1135669()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142131 :: Pre-requisite:
1. SDC4K application should be installed and running
2. DICOM package should be installed and configured. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142132 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142133 :: Click on the Search PACS button from the Patient Info screen The Import from PACS window should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142134 :: Enter the search criteria and click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142135 :: Select any Patient id and click on the Search studies button then select Study ID > Series ID and then click on import images/videos button. The Retrieval process should be started.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142136 :: While the retrieval process is in progress, Press on the Cancel button. While the Cancelling operation is being carried out, an information message should be displayed in the Status bar as Operation has been canceled.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Software shall display "Operation has been canceled." message on the status bar during DICOM cancel operation.<br>"
			+"Actual : Software shall display "Operation has been canceled." message on the status bar during DICOM cancel operation.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_122 : Verify that the software shall use the study instance UID for exporting the case on to the PACS server, if available. Otherwise the system generates its own UID. The UID should remain same for a case irrespective of the export/import operations.")]
[Owner("Gaurav Dhumal")]
public void TC_1135589()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142138 :: Pre-requisite: 1. Task Manager should already be open using the Task Manager Dongle. 2. SDC4K application should be installed and running 3. A valid DICOM server should be configured on the SDC4K application with Study Instance UID setting set to SCP Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142139 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142140 :: Enter a unique First Name, Last Name and Patient ID in the respective fields Unique First Name, Last Name and Patient ID should get entered in the respective fields");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142141 :: Navigate to the Capture screen. The operator should land on the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142142 :: Capture few images by clicking the Capture button Images should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142143 :: Click on the Media -> Export button The Export screen should be displayed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142144 :: Select Dicom server as the export option and click on the Export button The images should be exported to the Dicom server successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142145 :: Close the window . Click the End Case button and click Yes. The current case should end successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142146 :: Navigate to the current case Folder within the E:\Data folder and verify the presence of the studyinstanceuid attribute in the CaseDetails.dat file by decrypting the Casedetails.dat file into xml file. There should be no value assigned to the studyinstanceuid attribute in the CaseDetails.xml file.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142147 :: Navigate back to the SDC4K GUI and click on the Start Case button present on the Home screen New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142148 :: Click on the Search PACS button The operator should land on the Search PACS screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142149 :: Search for the patient id used above while creating the case and Click on the Search Studies button. The case should get searched for the patient which was used to create the case above.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142150 :: Select the desired series, click on the Import Images/Videos button and after selecting the assets then click on the add to album button. The operator should navigate to the Patient Info screen, the patients data should get filled with the data imported from PACS server and asset should be added to media gallery.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142151 :: Navigate to the current case Folder within the E:\Data folder and verify the presence of the studyinstanceuid attribute in the CaseDetails.dat file by decrypting the Casedetails.dat file into xml file. The UID value should be assigned to the studyinstanceuid attribute in the CaseDetails.xml file.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142152 :: Capture few images and export the current case to Dicom Server. Images should be captured and case should be successfully exported to Dicom Server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142153 :: Close the window . Click the End Case button and click Yes. The current case should end successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142154 :: Repeat test steps 11-15 after starting a new case. Test steps should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142155 :: Navigate to the current case Folder within the E:\Data folder and verify the presence of the studyinstanceuid attribute in the CaseDetails.dat file by decrypting the Casedetails.dat file into xml file. The UID value of studyinstanceuid attribute in the CaseDetails.xml file should be same as the UID value of the case imported above.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall use the study instance UID for exporting the case on to the PACS server, if available. Otherwise the system generates its own UID. The UID should remain same for a case irrespective of the export/import operations.<br>"
			+"Actual : Verify that the software shall use the study instance UID for exporting the case on to the PACS server, if available. Otherwise the system generates its own UID. The UID should remain same for a case irrespective of the export/import operations.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_123 : Verify that the software shall allow saving images to DICOM in DCM format. While converting an image to DCM format, Visible Light Endoscopy (VLES) shall be the default option.")]
[Owner("Gaurav Dhumal")]
public void TC_1135598()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142156 :: Preconditions:
1. SDC4K application should be installed and running.
2. A valid DICOM server should be configured on the SDC4K application with Storage Commit ON.
3. DICOM package should be installed.
4. The Modality should be set to ES in the DICOM Client settings.
5. A LAN configured for IPv4.
6. A wireless network configured for IPv4.
7. Connect SDC4K machine to LAN configured to IPv4. Preconditions should be met SDC4K machine is connected to LAN configured to IPv4.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142157 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142159 :: Enter valid data in the Patient ID, Patient First Name and Patient Last Name text fields. The data should be entered successfully in the Patient ID, Patient First Name and Patient Last Name text fields.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142160 :: Navigate to the Capture screen. The operator should be directed to the Capture screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142161 :: Capture few images by clicking the Capture button The images should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142162 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142163 :: Click on the Export button The operator should be directed to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142164 :: Select the DICOM server configured for IPv4 and click on the Export button The Dicom server should be selected and the export to DICOM server should initiate and the messages should be coming in the below mentioned sequence:
Preparing data…
Saving data to PACS…
Save successful to PACS.
Committing data to PACS…
Storage Commit successful. as information message if all the selected images are successfully committed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142165 :: Verify the exported files on the PACS server The Dicom_Data folder should be having the DICOM format files (DCM) files for the current case");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142166 :: Make sure LAN is disconnected.
Connect SDC4K machine to wireless network configured for IPv4.
Repeat test steps above SDC4K machine is connected to wireless network configured for IPv4.
Same expected result per test step.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall allow saving images to DICOM in DCM format. While converting an image to DCM format, Visible Light Endoscopy (VLES) shall be the default option.<br>"
			+"Actual : Verify that the software shall allow saving images to DICOM in DCM format. While converting an image to DCM format, Visible Light Endoscopy (VLES) shall be the default option.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_124 : Verify that the Media Gallery screen shall have a storage commit Icon above each image and video in current case which was successfully sent for Storage Commit.")]
[Owner("Gaurav Dhumal")]
public void TC_1136563()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142167 :: Pre-requisite:
1.SDC4K application should be installed and running. Dicom package should be installed.
2. A valid DICOM server should be configured on the SDC4K application with Storage Commit and the Dicom Video as ON Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142168 :: Create a new case from home screen. Verify the pop up message is displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142169 :: Click Yes and Enter valid data in the Patient ID, Patient First Name and Patient Last Name text fields. Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142170 :: Navigate to the Capture screen. The operator should be directed to the Capture screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142171 :: Capture few images/videos by clicking the Capture button The images/videos should get captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142172 :: Navigate to Media Gallery and click on the Export button. The operator should be directed to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142173 :: Select the Dicom server and click on the Export button The Dicom server should be selected and the export to DICOM server should initiate and the messages should be coming in the below mentioned sequence:
Preparing data…
Saving data to PACS…
Save successful to PACS.
Committing data to PACS…
Storage Commit successful. as information message if all the selected images and videos are successfully committed");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142174 :: Close the Export Screen and verify that the Media Gallery screen shall have a storage commit icon above each image and video which was committed successfully. The images/videos committed successfully to the DICOM server should be having a storage commit icon on it.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the Media Gallery screen shall have a storage commit Icon above each image and video in current case which was successfully sent for Storage Commit.<br>"
			+"Actual : Verify that the Media Gallery screen shall have a storage commit Icon above each image and video in current case which was successfully sent for Storage Commit.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_125 : Verify that the software allow selecting images from prior case stored on DICOM server, for printing")]
[Owner("Gaurav Dhumal")]
public void TC_1135611()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142175 :: Pre-requisite: 1. SDC4K application should be installed and running. 2. DICOM package should be installed. 3. A valid DICOM server should be configured on the SDC4K application. 4. A case should exist for a particular Patient Id on the DICOM server with DICOM images in it. 5. A printer should be connected with the SDC4K machine. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142176 :: Launch the SDC4K application and Create a new case from home screen. New case should be created..");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142178 :: Click on the Search PACS button from the Patient Info screen. The Import from PACS window should be launched successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142179 :: Enter the Patient Id (for e.g. 2333) in the Patient Id field which is having DICOM images in its existing case. Enter search criteria for Date Range and click on the Search button. The MWL search should get initiated and the results should be populated based upon the current search criteria.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142180 :: Select the patient id and click on the Search Studies button. The application should display the list of studies matching the selected Patient Id. Under every study, the available series should be present with information regarding asset count and modality.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142181 :: Select a series having images in it and click on the Import Images/Videos button. The application should start the image import process and should retrieve and display all the imported images on the SDC4K GUI.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142182 :: Select all the images and click on Add to Album button to add the retrieved images to the Media Gallery of the current case. The operator should navigate to the Patient Info screen and all the selected imported Images should be added to the Media Gallery of the current case.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142183 :: Navigate to the Media Gallery screen and check for the images in the Images tab. All the images should be displayed in Images tab of the Media Gallery.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142184 :: Verify user is allowed to select the images imported from DICOM server, select images to print and click on the Print button. User should be allowed to select imported images from Dicom for print operation. Images should be selected and Print pop up box should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142185 :: Click on Print button. Selected Images should get printed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software allow selecting images from prior case stored on DICOM server, for printing<br>"
			+"Actual : Verify that the software allow selecting images from prior case stored on DICOM server, for printing");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_126 : Verify that the software support storage of videos to PACS server")]
[Owner("Gaurav Dhumal")]
public void TC_1135604()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142186 :: Pre-requisite:
1. SDC4K application should be installed and running.
2. A valid DICOM/PACS server should be configured on the SDC4K application.
3. The DICOM Video option should be ON. Precondition should be executed successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142187 :: Create a new case from home screen. Verify the pop up message is displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142189 :: Click Yes and Enter patient id, patient first name and patient last name in the desired fields. Details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142190 :: Navigate to the Capture screen. Operator should navigate to the Capture screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142191 :: Use the Record button to record 2-3 videos. Videos should be recorded successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142192 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142193 :: Select videos to be exported to PACS server. Click on the Export button to navigate to the Export screen. Videos should be selected and the operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142194 :: Select DICOM and de-select all the other Export options from the Export screen. The DICOM export option should get selected successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142195 :: Click on the Export button to export the videos to the DICOM server. Export operation should be successful and selected videos should be saved to the DICOM server.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support storage of videos to PACS server<br>"
			+"Actual : Verify that the software support storage of videos to PACS server");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_127 : Verify if valid error message is displayed when PACS server is not communicating.")]
[Owner("Gaurav Dhumal")]
public void TC_1135608()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142196 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application. Shut down the machine on which DICOM server is running.
3. PACS should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142197 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142198 :: Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142199 :: Enter valid values in all the mandatory fields. Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142200 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142201 :: Capture an image by clicking on the Capture button The image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142202 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142203 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142204 :: Select the Dicom export option and all the other export options The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142205 :: Click on the Export button The export to PACS server should get initiated.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142206 :: Since DICOM Server is not running (refer pre-conditions), verify the error message on the global task bar of the SDC4K application. The Dicom application should throw error message on the global task bar saying Error saving to Dicom.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify if valid error message is displayed when PACS server is not communicating.<br>"
			+"Actual : Verify if valid error message is displayed when PACS server is not communicating.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_128 : Verify and validate that the application shall display Saving only images to PACS message when DICOM Video is OFF for that case or the case contains videos and Save Videos to PACS option is selected as NO in the begining of a new case.")]
[Owner("Gaurav Dhumal")]
public void TC_1135610()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142207 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application. Turn ON DICOM Video from DICOM Settings.
3. PACS should be checked as a Export Option under Export Settings. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142209 :: Create a new case from home screen. Verify the pop up message is displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142210 :: Select No and Enter valid values in all the mandatory fields. Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142211 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142212 :: Capture an image and record some Videos. The image should be captured and Videos should be recorded successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142213 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142214 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142215 :: Select the Dicom export option. The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142216 :: Click on the Export button The export to PACS server should should get initiated. Only the Images should be saved for the current case and the corresponding Information message Saving only images to PACS should be displayed at the Status bar.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142217 :: Login to DICOM Server where the case has been saved and check for the case being received. Only images should be exported and saved to the DICOM Server. Case images should be present only.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142218 :: Repeat the steps above after turning OFF the DICOM video from the settings. Only images should be exported and saved to DICOM server. Same message Saving only images to PACS should be displayed.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify and validate that the application shall display Saving only images to PACS message when DICOM Video is OFF for that case or the case contains videos and Save Videos to PACS option is selected as NO in the begining of a new case.<br>"
			+"Actual : Verify and validate that the application shall display Saving only images to PACS message when DICOM Video is OFF for that case or the case contains videos and Save Videos to PACS option is selected as NO in the begining of a new case.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_129 : Verify and validate that the software shall handle saving of only one case to PACS server at a time.")]
[Owner("Gaurav Dhumal")]
public void TC_1135600()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142219 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application and dicom video should be ON.
3. PACS should be checked as a Export Option under Export Settings. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142220 :: Create a new case from home screen. Verify the pop up message is displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142221 :: Click on Yes button and Enter valid values in all the mandatory fields. Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142222 :: Navigate to the Capture screen. The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142223 :: Capture an image and record some Videos. The image should be captured and Videos should be recorded successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142224 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142225 :: Click on the Export button The operator should navigate to the Export screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142227 :: Select the Dicom export option The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142228 :: Click on the Export button Only a single Case can be saved to the selected PACS Server at a time. While the Export is in progress, user shall not allowed to End the case OR to move to Archived screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify and validate that the software shall handle saving of only one case to PACS server at a time.<br>"
			+"Actual : Verify and validate that the software shall handle saving of only one case to PACS server at a time.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_130 : Verify that the software shall display the below messages on status bar while saving a case to DICOM server and Storage Commit is ON:
Preparing data…
Saving data to PACS…
Save successful to PACS…
Committing data to PACS…
"Storage Commit failed." as error message if all the selected images are not committed.")]
[Owner("Gaurav Dhumal")]
public void TC_1135593()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142229 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with Storage Commit Setting turned ON
3.Port number(other than 104) should be configured in the client settings of the dicom server. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142230 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142231 :: Enter a valid Patient ID, First Name, and Last Name in the respective fields. Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142232 :: Navigate to the Capture screen. The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142233 :: Capture 5 images by clicking the Capture button Images should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142234 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142235 :: Click on the Export button The operator should navigate to the Export screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142236 :: Select the Dicom export option and make sure no other export option is selected. The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142237 :: Click on the Export button and verify the messages coming on the global task bar in case if all the selected images are not committed The export to DICOM server should initiate and the messages should be coming in the below mentioned sequence:
Preparing data…
Saving data to PACS…
Save successful to PACS.
Committing data to PACS…
Storage Commit failed. as error message if all the selected images are not committed");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software shall display the below messages on status bar while saving a case to DICOM server and Storage Commit is ON:
Preparing data…
Saving data to PACS…
Save successful to PACS…
Committing data to PACS…
"Storage Commit failed." as error message if all the selected images are not committed.<br>"
			+"Actual : Verify that the software shall display the below messages on status bar while saving a case to DICOM server and Storage Commit is ON:
Preparing data…
Saving data to PACS…
Save successful to PACS…
Committing data to PACS…
"Storage Commit failed." as error message if all the selected images are not committed.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_131 : Verify and validate that the software handle all the errors as reported by the DICOM server and display appropriate messages to the user.")]
[Owner("Gaurav Dhumal")]
public void TC_1135609()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142238 :: Pre-requisite:
1. SDC4K application should be installed and running
2. A DICOM server should be configured and Dicom Video should be ON.
3. PACS should be checked as a Export Option under Export Settings.
4.SDC4K should be connected to network via LAN. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142239 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142240 :: Create a new case from home screen. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142241 :: Click on Yes and Enter valid values in all the mandatory fields. The values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142242 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142243 :: Capture an image and record some Videos. The image should be captured and Videos should be recorded successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142244 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142245 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142246 :: Select the Dicom export option. The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142247 :: Click on the Export button and while export is in progress disconnect the network cable. Error message should be displayed as Error saving to Dicom.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142248 :: Reconnect the Network cable and Navigate back to the patient info screen and enter the Invalid Patient information. User should be able to enter the details in Edit Patient screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142249 :: Click on Search PACS button Import from PACS screen should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142251 :: Select Date range as all and Modality as all and press Search Studies button Error message should be displayed as No records found");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142252 :: Disconnect the Network cable again and Navigate back to the Patient info screen and enter the Valid Patient information. User should be able to enter the details in Edit Patient screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142253 :: Click on Search PACS button Import from PACS screen should appear.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142254 :: Select Date range as all and Modality as all and press Search Studies button Error message should be displayed as Patient not found");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify and validate that the software handle all the errors as reported by the DICOM server and display appropriate messages to the user.<br>"
			+"Actual : Verify and validate that the software handle all the errors as reported by the DICOM server and display appropriate messages to the user.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_132 : To verify that while converting an image to DCM format, the software shall embed the annotation text inside the image if the annotation for the image is available.")]
[Owner("Gaurav Dhumal")]
public void TC_1135601()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142255 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A DICOM server should be configured.
3. PACS should be checked as a Export Option under Export Settings. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142256 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142257 :: Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142258 :: Enter valid values in all the mandatory fields. Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142259 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142260 :: Capture an image using Capture button. The image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142261 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142262 :: Annotate the Images from Media Gallery screen. Image should be annotated successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142263 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142264 :: Select the Dicom server from the Export List. The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142265 :: Click on the Export button. DICOM Images should be exported successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142266 :: End the current case and create a New case again. The last current case should be Archived and the new case creation wizard should be started.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142267 :: Enter the Patient ID of last case and retrieve the Images using Search PACS option. The last saved case should be retrieved successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142268 :: Select the retrieved images and press add to album. Images should be added successfully in the media gallery.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142269 :: Select the image and click Display button. Image along with annotation should be displayed on the OSD");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142271 :: Now print the selected images. Select images should be printed with annotation embedded in the image");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that while converting an image to DCM format, the software shall embed the annotation text inside the image if the annotation for the image is available.<br>"
			+"Actual : To verify that while converting an image to DCM format, the software shall embed the annotation text inside the image if the annotation for the image is available.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_133 : Verify that the software display "Do you want to save videos to PACS?" popup message when the operator creates new case and DICOM Video setting is ON")]
[Owner("Gaurav Dhumal")]
public void TC_1136317()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142272 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3.Channel Mode should be set to Single. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142273 :: Launch the SDC4K application The SDC4K application should be launched successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142274 :: From global task bar, navigate to Menu > Settings > Server > DICOM > Settings Operator should land on the DICOM settings screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142275 :: Click on the DICOM Video setting to turn the status to ON The status of the DICOM Video setting should turn to ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142276 :: Navigate to home screen and start a case. Verify the Do you want to save videos to PACS? popup message. Do you want to save videos to PACS popup should be displayed with Yes and No options on the SDC4K application GUI as the DICOM Video setting is ON.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software display "Do you want to save videos to PACS?" popup message when the operator creates new case and DICOM Video setting is ON<br>"
			+"Actual : Verify that the software display "Do you want to save videos to PACS?" popup message when the operator creates new case and DICOM Video setting is ON");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_134 : To verify that If encryption is ON ,the software shall not create .dcm files for selected videos while saving a case to USB when options in the export setting screens for "PACS" is checked and Save Videos to PACS is ON else if encryption is OFF, the software shall create .dcm files for selected Images while saving a case to USB when option in the export setting screens for "PACS" is checked and Save Videos to PACS is ON.")]
[Owner("Gaurav Dhumal")]
public void TC_1135603()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142277 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application. DICOM Video should be turned ON.
3. PACS should be checked as a Export Option under Export Settings. Preconditions should be met.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142278 :: Create a new case from home screen. Verify the pop up message is displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142279 :: Click Yes. Operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142280 :: Enter valid values in all the mandatory fields. Details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142281 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142282 :: Capture an image and record some Videos. The image should be captured and Videos should be recorded successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142283 :: Navigate to Media gallery screen. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142284 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142285 :: From Export Settings screen, make sure Encryption should be ON. Encryption should be ON");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142286 :: Navigate back to export screen, Connect a USB and select USB as export option. Click Export. All the recorded images and videos should be successfully saved to USB.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142287 :: Open the case saved to USB on a computer. In addition to the saved images /videos in respective formats, NO image and video in the USB should have .DCM files.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142288 :: Now again export the media to USB while Encryption is set OFF in export settings. All images should be saved in DICOM format (.dcm) along with the Image format selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : To verify that If encryption is ON ,the software shall not create .dcm files for selected videos while saving a case to USB when options in the export setting screens for "PACS" is checked and Save Videos to PACS is ON else if encryption is OFF, the software shall create .dcm files for selected Images while saving a case to USB when option in the export setting screens for "PACS" is checked and Save Videos to PACS is ON.<br>"
			+"Actual : To verify that If encryption is ON ,the software shall not create .dcm files for selected videos while saving a case to USB when options in the export setting screens for "PACS" is checked and Save Videos to PACS is ON else if encryption is OFF, the software shall create .dcm files for selected Images while saving a case to USB when option in the export setting screens for "PACS" is checked and Save Videos to PACS is ON.");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_135 : Verify that the software support conversion of images into DICOM format (DCM) for writing into storage medium")]
[Owner("Gaurav Dhumal")]
public void TC_1135596()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142289 :: Pre-requisite:
1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application.
3. PACS and USB should be checked as a Export Option under Export Settings
4.Encryption should be Off under the export setting screen. Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142290 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142291 :: Enter valid values in all the mandatory fields. Details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142293 :: Navigate to the Capture screen. The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142294 :: Capture an image by clicking on the Capture button. The image should be captured successfully.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142295 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142296 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142297 :: Select the USB export option and unselect all the other export options The USB export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142298 :: Connect a USB flash drive to the SDC4K machine and click on the Export button The case should get saved in the connected USB flash drive");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142299 :: Verify the information saved on the USB flash drive by opening the content saved in it The case folder should be having a DICOM format (.dcm) file in it along with the image format selected.");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software support conversion of images into DICOM format (DCM) for writing into storage medium<br>"
			+"Actual : Verify that the software support conversion of images into DICOM format (DCM) for writing into storage medium");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_136 : Verify that the software allow exporting only DICOM format files (DCM file) into PACS server")]
[Owner("Gaurav Dhumal")]
public void TC_1135585()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142300 :: Pre-requisite:
1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application.
3. PACS should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142301 :: Launch the SDC4K application and Create a new case from home screen. New case should be started and operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142302 :: Enter Patient details. Patient Details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142303 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142304 :: Capture an image by clicking on the Capture button The image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142305 :: Navigate to Media gallery tab. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142306 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142307 :: Select the Dicom export option. The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142308 :: Click on the Export button The case should get saved on the configured Dicom server");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142309 :: Verify the exported files on the Dicom server Only DICOM format files (DCM file) should be present in PACS server");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software allow exporting only DICOM format files (DCM file) into PACS server<br>"
			+"Actual : Verify that the software allow exporting only DICOM format files (DCM file) into PACS server");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_137 : Verify that the software be able to display progress while the case is being exported to DICOM")]
[Owner("Gaurav Dhumal")]
public void TC_1135599()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142310 :: Pre-requisite:
1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application
3. PACS should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142311 :: Launch the SDC4K application and Create a new case from home screen. New case should be created.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142312 :: Enter valid values in all the mandatory fields including Patient ID, First Name, Last Name, Date of Birth. Details should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142313 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142314 :: Capture an image by clicking on the Capture button The image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142315 :: Navigate to Media gallery screen. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142317 :: Click on the Export button The operator should navigate to Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142318 :: Select the Dicom export option and make sure no other option is selected The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142319 :: Click on the Export button The case should get saved on the configured Dicom server");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142320 :: Verify that the SDC4K application should display progress while the case is being exported to the DICOM server The SDC4K application should display a blue color progress bar running on the Dicom export option while the case is being exported to the DICOM server");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software be able to display progress while the case is being exported to DICOM<br>"
			+"Actual : Verify that the software be able to display progress while the case is being exported to DICOM");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message);
	}
}
[TestMethod]
[TestCategory()]
[Description(@"SDC4K_SG_DCM_138 : Verify that the software enforce the operator to enter all the required data (patient demographics data) before converting to DICOM format only when the current case is exported to PACS")]
[Owner("Gaurav Dhumal")]
public void TC_1135605()
{
	try
	{
		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142321 :: Pre-requisite: 1. SDC4K application should be installed and running
2. A valid DICOM server should be configured on the SDC4K application with DICOM Video setting set to ON
3. PACS should be checked as a Export Option under Export Settings Precondition should be executed successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142322 :: Create a new case from home screen. Verify the pop up message is displayed. Do you want to save videos to PACS popup should be displayed with Yes and No options.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142323 :: Click Yes. New case should be started and operator should land on the Patient Info screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142324 :: Don't enter any value in the mandatory fields. No Values should be entered.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142325 :: Navigate to the Capture screen The operator should navigate to the Capture screen");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142326 :: Capture an image by clicking on the Capture button The image should be captured successfully");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142327 :: Navigate to Media gallery screen. Operator should land on the Media Gallery screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142328 :: Click on the Export button The operator should navigate to the Export screen.");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142329 :: Select the Dicom export option and make sure no other option is selected. The Dicom export option should be selected");

		CommonFunction.LogStatusForReport(Status.Pass, "Test Step Id:: 1142330 :: Click on the Export button The SDC4K application should take the operator to the Patient Info screen and highlight all the mandatory fields with RED color border");

		CommonFunction.LogStatusForReport(Status.Pass, "Expected : Verify that the software enforce the operator to enter all the required data (patient demographics data) before converting to DICOM format only when the current case is exported to PACS<br>"
			+"Actual : Verify that the software enforce the operator to enter all the required data (patient demographics data) before converting to DICOM format only when the current case is exported to PACS");
	}
	catch (Exception e)
	{
		Logging.GetLogger().Error(System.Reflection.MethodBase.GetCurrentMethod() + e.Message);
		Assert.Fail(e.Message