#include <ButtonConstants.au3>
#include <EditConstants.au3>
#include <GUIConstantsEx.au3>
#include <StaticConstants.au3>
#include <TabConstants.au3>
#include <WindowsConstants.au3>
#Region ### START Koda GUI section ### Form=gui_easymapping.kxf
$Form1 = GUICreate("EasyMapping", 801, 601, 311, 272)
GUISetIcon("C:\Users\Malve\Desktop\GUI\Forms\Logo48x48.ico", -1)
GUISetBkColor(0x000000)
$TabMenu = GUICtrlCreateTab(0, 0, 800, 560)
$Settings = GUICtrlCreateTabItem("Settings")
$ImportSettings = GUICtrlCreateGroup("Import", 14, 35, 770, 145)
GUICtrlSetColor(-1, 0xC8C8C8)
GUICtrlSetBkColor(-1, 0x646464)
$Label1 = GUICtrlCreateLabel("Compatible ONLY with Neversink's loot filter. You can download it at www.filterblade.xyz", 24, 56, 489, 19)
GUICtrlSetFont(-1, 10, 400, 0, "calibri")
GUICtrlCreateInput("...", 34, 85, 153, 21)
$ImportLF = GUICtrlCreateButton("Import", 199, 83, 99, 25)
$Label2 = GUICtrlCreateLabel("Waiting Loot Filter Import", 314, 85, 146, 19)
GUICtrlSetFont(-1, 10, 400, 0, "calibri")
$Label3 = GUICtrlCreateLabel("(Optional) - Set Counter Function NEED SSID", 24, 113, 242, 19)
GUICtrlSetFont(-1, 10, 400, 0, "calibri")
GUICtrlCreateInput("Paste SSID", 34, 141, 409, 21)
$VerfySSID = GUICtrlCreateButton("Verfy", 464, 140, 75, 25)
$Label4 = GUICtrlCreateLabel("SSID Correct", 564, 141, 71, 19)
GUICtrlSetFont(-1, 10, 400, 0, "calibri")
GUICtrlCreateGroup("", -99, -99, 1, 1)
$ChaosSetTab = GUICtrlCreateTabItem("Chaos Set")
GUICtrlSetState(-1,$GUI_SHOW)
$Checkbox2 = GUICtrlCreateCheckbox("Enable Chaos Set Fast-On/Off", 39, 45, 233, 20)
GUICtrlSetState(-1, $GUI_CHECKED)
GUICtrlSetColor(-1, 0xC8C8C8)
$Group2 = GUICtrlCreateGroup("Show / Hide Loot Base Tyoe", 14, 77, 770, 450)
GUICtrlSetColor(-1, 0xC8C8C8)
$Checkbox1 = GUICtrlCreateCheckbox("", 34, 137, 97, 17)
$Checkbox3 = GUICtrlCreateCheckbox("Ring", 34, 157, 97, 17)
$Checkbox4 = GUICtrlCreateCheckbox("Amulet", 34, 177, 97, 17)
$Checkbox5 = GUICtrlCreateCheckbox("Helmet", 34, 197, 97, 17)
$Checkbox6 = GUICtrlCreateCheckbox("Body", 34, 217, 97, 17)
$Checkbox7 = GUICtrlCreateCheckbox("Belt", 34, 237, 97, 17)
$Checkbox8 = GUICtrlCreateCheckbox("Gloves", 34, 257, 97, 17)
$Checkbox9 = GUICtrlCreateCheckbox("Boots", 34, 277, 97, 17)
$Checkbox10 = GUICtrlCreateCheckbox("Weapon", 34, 297, 97, 17)
$Radio1 = GUICtrlCreateRadio("", 224, 237, 15, 17)
$Radio2 = GUICtrlCreateRadio("", 224, 257, 15, 17)
$Radio3 = GUICtrlCreateRadio("", 144, 217, 15, 17)
$Radio4 = GUICtrlCreateRadio("", 184, 237, 15, 17)
$Radio5 = GUICtrlCreateRadio("", 184, 197, 15, 17)
$Radio6 = GUICtrlCreateRadio("", 144, 197, 15, 17)
$Radio7 = GUICtrlCreateRadio("", 144, 237, 15, 17)
$Radio8 = GUICtrlCreateRadio("", 144, 257, 15, 17)
$Radio9 = GUICtrlCreateRadio("", 184, 217, 15, 17)
$Radio10 = GUICtrlCreateRadio("", 184, 257, 15, 17)
$Radio11 = GUICtrlCreateRadio("", 224, 217, 15, 17)
$Radio12 = GUICtrlCreateRadio("", 224, 277, 15, 17)
$Radio13 = GUICtrlCreateRadio("", 144, 297, 15, 17)
$Radio14 = GUICtrlCreateRadio("", 184, 297, 15, 17)
$Radio15 = GUICtrlCreateRadio("", 184, 277, 15, 17)
$Radio16 = GUICtrlCreateRadio("", 144, 277, 15, 17)
$Radio17 = GUICtrlCreateRadio("", 224, 157, 15, 17)
$Radio18 = GUICtrlCreateRadio("", 184, 157, 15, 17)
$Radio19 = GUICtrlCreateRadio("", 144, 157, 15, 17)
$Radio20 = GUICtrlCreateRadio("", 224, 177, 15, 17)
$Radio21 = GUICtrlCreateRadio("", 184, 177, 15, 17)
$Radio22 = GUICtrlCreateRadio("", 144, 177, 15, 17)
$Radio23 = GUICtrlCreateRadio("", 224, 197, 15, 17)
$Radio24 = GUICtrlCreateRadio("", 224, 297, 15, 17)
GUICtrlCreateGroup("", -99, -99, 1, 1)
$RegalSetTab = GUICtrlCreateTabItem("Regal Set")
$SetCounter = GUICtrlCreateTabItem("Set Counter")
GUICtrlCreateTabItem("")
$CloseGUI = GUICtrlCreateButton("Close", 700, 568, 75, 25)
$SaveHideGUI = GUICtrlCreateButton("Save and Hide", 600, 568, 85, 25)
$SaveGUI = GUICtrlCreateButton("Save", 510, 568, 75, 25)
GUISetState(@SW_SHOW)
#EndRegion ### END Koda GUI section ###

While 1
	$nMsg = GUIGetMsg()
	Switch $nMsg
		Case $GUI_EVENT_CLOSE
			Exit

	EndSwitch
WEnd
