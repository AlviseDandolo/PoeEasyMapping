#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.14.5
 Author:         AlviDandee & Malve8

#ce ----------------------------------------------------------------------------

#Include <Constants.au3>
#include <GuiEdit.au3>
#Include <GUIConstants.Au3>
#include <GUIConstantsEx.au3>
#include <ButtonConstants.au3>
#include <WindowsConstants.au3>
#include <MsgBoxConstants.au3>
#include <ComboConstants.au3>
#include <ColorConstants.au3>
#include <InetConstants.au3>
#include <FileConstants.au3>
#include <TabConstants.au3>
#include <FontConstants.au3>
#include <EditConstants.au3>
#include <GuiListView.au3>
#include <Math.au3>
#include <Array.au3>
#include <WinAPI.au3>
#include <File.au3>
#include <GDIPlus.au3>
#include <WinAPIGdi.au3>
#include "lib/JSON.au3"
#include "lib/DownloadHelper.au3"
#include "lib/ColorPicker.au3"
#RequireAdmin

Opt("GUIOnEventMode", 1)
Opt("GuiNotifyMode", 1)
Opt("GUIResizeMode", $GUI_DOCKALL)
Opt("WinWaitDelay", 10)
Opt("WinTitleMatchMode", 3)
Opt('MustDeclareVars', 1)

Global Const $SC_DRAGMOVE = 0xF012
Global Const $WIN_TITLE = "PoE Easy Mapping"
Global Const $INI_PATH = @ScriptDir & "\settings.ini"

_WinAPI_AddFontResourceEx(@ScriptDir & "\font\Fontin-SmallCaps.otf", $FR_PRIVATE, False)

Global $aPalette[117] = _
    [0x330000, 0x331900, 0x333300, 0x193300, 0x003300, 0x003319, 0x003333, 0x001933, 0x000033, 0x190033, 0x330033, 0x330019, 0x000000, _
     0x660000, 0x663300, 0x666600, 0x336600, 0x006600, 0x006633, 0x006666, 0x003366, 0x000066, 0x330066, 0x660066, 0x660033, 0x202020, _
     0x990000, 0x994C00, 0x999900, 0x4C9900, 0x009900, 0x00994C, 0x009999, 0x004C99, 0x000099, 0x4C0099, 0x990099, 0x99004C, 0x404040, _
     0xCC0000, 0xCC6600, 0xCCCC00, 0x66CC00, 0x00CC00, 0x00CC66, 0x00CCCC, 0x0066CC, 0x0000CC, 0x6600CC, 0xCC00CC, 0xCC0066, 0x606060, _
     0xFF0000, 0xFF8000, 0xFFFF00, 0x80FF00, 0x00FF00, 0x00FF80, 0x00FFFF, 0x0080FF, 0x0000FF, 0x7F00FF, 0xFF00FF, 0xFF007F, 0x808080, _
     0xFF3333, 0xFF9933, 0xFFFF33, 0x99FF33, 0x33FF33, 0x33FF99, 0x33FFFF, 0x3399FF, 0x3333FF, 0x9933FF, 0xFF33FF, 0xFF3399, 0xA0A0A0, _
     0xFF6666, 0xFFB266, 0xFFFF66, 0xB2FF66, 0x66FF66, 0x66FFB2, 0x66FFFF, 0x66B2FF, 0x6666FF, 0xB266FF, 0xFF66FF, 0xFF66B2, 0xC0C0C0, _
     0xFF9999, 0xFFCC99, 0xFFFF99, 0xCCFF99, 0x99FF99, 0x99FFCC, 0x99FFFF, 0x99CCFF, 0x9999FF, 0xCC99FF, 0xFF99FF, 0xFF99CC, 0xE0E0E0, _
     0xFFCCCC, 0xFFE5CC, 0xFFFFCC, 0xE5FFCC, 0xCCFFCC, 0xCCFFE5, 0xCCFFFF, 0xCCE5FF, 0xCCCCFF, 0xE5CCFF, 0xFFCCFF, 0xFFCCE5, 0xFFFFFF]

Global $TabsVisible = False
Global $TabsHandleActive = True
Global $SettingsVisible = False

Global $Scan = False
Global $UserTabs = ObjCreate("System.Collections.ArrayList")

Global $MainVisible = IniRead($INI_PATH, "Filter", "MainVisible", true)
Global $AmuletVisible = IniRead($INI_PATH, "Filter", "AmuletVisible", true)
Global $RingVisible = IniRead($INI_PATH, "Filter", "RingVisible", true)
Global $BeltVisible = IniRead($INI_PATH, "Filter", "BeltVisible", true)
Global $HelmetVisible = IniRead($INI_PATH, "Filter", "HelmetVisible", true)
Global $BodyVisible = IniRead($INI_PATH, "Filter", "BodyVisible", true)
Global $GlovesVisible = IniRead($INI_PATH, "Filter", "GlovesVisible", true)
Global $BootsVisible = IniRead($INI_PATH, "Filter", "BootsVisible", true)
Global $WeaponVisible = IniRead($INI_PATH, "Filter", "WeaponVisible", true)

Global $Username = IniRead($INI_PATH, "Inspector", "Username", "")
Global $POESESSID = IniRead($INI_PATH, "Inspector", "POESESSID", "")
Global $ActiveLeagueName = IniRead($INI_PATH, "Inspector", "ActiveLeague", "")
Global $SelectedTabIDs = IniRead($INI_PATH, "Inspector", "SelectedTabs", "")

Global $WindowXPos = IniRead($INI_PATH, "General", "WindowX", 1000)
Global $WindowYPos = IniRead($INI_PATH, "General", "WindowY", 1000)

Global $FontSize = 45, $BgVisible = true, $BgColor = 0x000000, $BgAlpha = 255, $BorderVisible = true, $BorderColor = 0xEEEEEE, $BorderAlpha = 255, $FontVisible = true, $FontColor = 0xEEEEEE, $FontAlpha = 255
Global $BoxWidth = $FontSize*6.9 + 20
Global $BoxHeight = $FontSize/2 + 20

_GDIPlus_Startup()

; ############################## GUI ##############################

; Create the window
Global $MainWindow = GUICreate($WIN_TITLE, 512, 64, $WindowXPos, $WindowYPos, $WS_POPUP)
GUISetBkColor(0x000000)
WinSetOnTop($WIN_TITLE, "", $WINDOWS_ONTOP)

Global $MainTitleWindow = GUICreate($WIN_TITLE & " Title", 392, 22, 3, 3, $WS_POPUP, BitOR($WS_EX_MDICHILD,$WS_EX_TRANSPARENT), $MainWindow)
GUISetBkColor(0x000000)
Global $MainWindow_Title = GUICtrlCreateLabel($WIN_TITLE, 3, 1, 384, 20, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetColor(-1, 0xF2F2F2)
GUICtrlSetFont($MainWindow_Title, 14, 100, $GUI_FONTNORMAL, 'Fontin SmallCaps', $PROOF_QUALITY)

GUISwitch($MainWindow)
; Create the reduce/close window buttons
Global $Button_Exit = GUICtrlCreateLabel("×", 472, 0, 40, 24, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetBkColor(-1, 0xDC0000)
GUICtrlSetColor(-1, 0xF2F2F2)
Global $Button_Minimize = GUICtrlCreateLabel("_", 432, 0, 40, 24, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetBkColor(-1, 0x6E6E6E)
GUICtrlSetColor(-1, 0xF2F2F2)
Global $Button_Anchor = GUICtrlCreateLabel("📌", 392, 0, 40, 24, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetBkColor(-1, 0x3D3800)
GUICtrlSetColor(-1, 0xF2F2F2)
Global $Button_Settings = GUICtrlCreateLabel("Settings", 392, 24, 120, 40, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetFont($Button_Settings, 16, 100, $GUI_FONTNORMAL, 'Fontin SmallCaps', $PROOF_QUALITY)
GUICtrlSetBkColor(-1, 0x1E1E1E)
GUICtrlSetColor(-1, 0xF2F2F2)
GUICtrlCreateGraphic(0, 23, 392, 1, $SS_BLACKRECT)
GUICtrlCreateGraphic(56, 28, 1, 32, $SS_BLACKRECT)
GUICtrlSetOnEvent($Button_Settings, "SettingsVisibilityToggle")

; Add visibility toggle buttons
Global $MainVisibilityToggleButton = GUICtrlCreateButton ("", 10, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($MainVisibilityToggleButton, @ScriptDir & "\img\Visibility_ON.bmp")
GUICtrlSetOnEvent($MainVisibilityToggleButton, "MainVisibilityToggle")

Global $TabVisibilityToggleButton = GUICtrlCreateButton ("", 300, 100, 32, 32, $BS_BITMAP)
GUICtrlSetImage($TabVisibilityToggleButton, @ScriptDir & "\img\Visibility_ON.bmp")
GUICtrlSetOnEvent($TabVisibilityToggleButton, "TabVisibilityToggle")

Global $AmuletVisibilityToggleButton = GUICtrlCreateButton ("", 70, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($AmuletVisibilityToggleButton, @ScriptDir & "\img\Amulet_ON.bmp")
GUICtrlSetOnEvent($AmuletVisibilityToggleButton, "ClassVisibilityToggle")

Global $RingVisibilityToggleButton = GUICtrlCreateButton ("", 110, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($RingVisibilityToggleButton, @ScriptDir & "\img\Ring_ON.bmp")
GUICtrlSetOnEvent($RingVisibilityToggleButton, "ClassVisibilityToggle")

Global $BeltVisibilityToggleButton = GUICtrlCreateButton ("", 150, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($BeltVisibilityToggleButton, @ScriptDir & "\img\Belt_ON.bmp")
GUICtrlSetOnEvent($BeltVisibilityToggleButton, "ClassVisibilityToggle")

Global $HelmetVisibilityToggleButton = GUICtrlCreateButton ("", 190, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($HelmetVisibilityToggleButton, @ScriptDir & "\img\Helmet_ON.bmp")
GUICtrlSetOnEvent($HelmetVisibilityToggleButton, "ClassVisibilityToggle")

Global $BodyVisibilityToggleButton = GUICtrlCreateButton ("", 230, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($BodyVisibilityToggleButton, @ScriptDir & "\img\Body_ON.bmp")
GUICtrlSetOnEvent($BodyVisibilityToggleButton, "ClassVisibilityToggle")

Global $GlovesVisibilityToggleButton = GUICtrlCreateButton ("", 270, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($GlovesVisibilityToggleButton, @ScriptDir & "\img\Gloves_ON.bmp")
GUICtrlSetOnEvent($GlovesVisibilityToggleButton, "ClassVisibilityToggle")

Global $BootsVisibilityToggleButton = GUICtrlCreateButton ("", 310, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($BootsVisibilityToggleButton, @ScriptDir & "\img\Boots_ON.bmp")
GUICtrlSetOnEvent($BootsVisibilityToggleButton, "ClassVisibilityToggle")

Global $WeaponVisibilityToggleButton = GUICtrlCreateButton ("", 350, 28, 32, 32, $BS_BITMAP)
GUICtrlSetImage($WeaponVisibilityToggleButton, @ScriptDir & "\img\Weapon_ON.bmp")
GUICtrlSetOnEvent($WeaponVisibilityToggleButton, "ClassVisibilityToggle")

#cs
; Add set counters
$ChaosAmuletsLabel = GUICtrlCreateLabel("", 50, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosAmuletsLabel, 0xede73d)
$RegalAmuletsLabel = GUICtrlCreateLabel("", 50, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalAmuletsLabel, 0x6db3ff)

$ChaosRingsLabel = GUICtrlCreateLabel("", 90, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosRingsLabel, 0xede73d)
$RegalRingsLabel = GUICtrlCreateLabel("", 90, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalRingsLabel, 0x6db3ff)

$ChaosBeltsLabel = GUICtrlCreateLabel("", 130, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosBeltsLabel, 0xede73d)
$RegalBeltsLabel = GUICtrlCreateLabel("", 130, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalBeltsLabel, 0x6db3ff)

$ChaosHelmetsLabel = GUICtrlCreateLabel("", 170, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosHelmetsLabel, 0xede73d)
$RegalHelmetsLabel = GUICtrlCreateLabel("", 170, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalHelmetsLabel, 0x6db3ff)

$ChaosChestsLabel = GUICtrlCreateLabel("", 210, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosChestsLabel, 0xede73d)
$RegalChestsLabel = GUICtrlCreateLabel("", 210, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalChestsLabel, 0x6db3ff)

$ChaosGlovesLabel = GUICtrlCreateLabel("", 250, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosGlovesLabel, 0xede73d)
$RegalGlovesLabel = GUICtrlCreateLabel("", 250, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalGlovesLabel, 0x6db3ff)

$ChaosBootsLabel = GUICtrlCreateLabel("", 290, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosBootsLabel, 0xede73d)
$RegalBootsLabel = GUICtrlCreateLabel("", 290, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalBootsLabel, 0x6db3ff)

$ChaosWeaponsLabel = GUICtrlCreateLabel("", 330, 50, 32, 30, $SS_CENTER)
GUICtrlSetColor($ChaosWeaponsLabel, 0xede73d)
$RegalWeaponsLabel = GUICtrlCreateLabel("", 330, 70, 32, 30, $SS_CENTER)
GUICtrlSetColor($RegalWeaponsLabel, 0x6db3ff)
#ce

; Add tab search form
Global $LeagueComboBox = GUICtrlCreateCombo("", 10, 100, 120, -1, $CBS_DROPDOWNLIST)
Global $POESESSIDInput = GUICtrlCreateInput($POESESSID, 10, 130, 200, 20)
Global $FetchTabsButton = GUICtrlCreateButton("Fetch tabs", 10, 160, 80, 25)
Global $TabListView = GUICtrlCreateListView("Name|id|index", 10, 190, 200, 200, BitOr($LVS_REPORT,$LVS_NOCOLUMNHEADER), $LVS_EX_CHECKBOXES)
Global $FetchTabContentButton = GUICtrlCreateButton("Fetch tab content", 10, 400, 120, 25)

; Tabs window
Global $TabsHandleWindow = GUICreate($WIN_TITLE & " Tabs", 250, 250, 100, 100, $WS_POPUP)
WinSetOnTop($WIN_TITLE & " Tabs", "", $WINDOWS_ONTOP)
GUISetBkColor(0x000000)
Global $TabsWindow = GUICreate($WIN_TITLE & " Tabs Content", 250, 250, 100, 100, $WS_POPUP, BitOR($WS_EX_MDICHILD,$WS_EX_TRANSPARENT), $TabsHandleWindow)
WinSetOnTop($WIN_TITLE & " Tabs Content", "", $WINDOWS_ONTOP)
GUISetBkColor(0x000000)
Global $bgPic = GUICtrlCreatePic(@ScriptDir & "\img\12x12grid.jpg", 0, 0, 569, 569)
GUICtrlSetPos($bgPic, 0, 0, 250, 250)

; Settings window
Global $SettingsWindow = GUICreate($WIN_TITLE & " Settings", 500, 500, 300, 700, $WS_POPUP)
WinSetOnTop($WIN_TITLE & " Settings", "", $WINDOWS_ONTOP)
GUISetBkColor(0x000000)

Global $SettingsTitleWindow = GUICreate($WIN_TITLE & " Settings Title", 460, 22, 3, 3, $WS_POPUP, BitOR($WS_EX_MDICHILD,$WS_EX_TRANSPARENT), $SettingsWindow)
GUISetBkColor(0x000000)
Global $SettingsWindow_Title = GUICtrlCreateLabel("Settings", 3, 1, 460, 20, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetColor(-1, 0xF2F2F2)
GUICtrlSetFont($SettingsWindow_Title, 14, 100, $GUI_FONTNORMAL, 'Fontin SmallCaps', $PROOF_QUALITY)

GUISwitch($SettingsWindow)
Global $Settings_Button_Exit = GUICtrlCreateLabel("×", 460, 0, 40, 24, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetBkColor(-1, 0xDC0000)
GUICtrlSetColor(-1, 0xF2F2F2)
GUICtrlSetOnEvent($Settings_Button_Exit, "SettingsVisibilityToggle")

Global $SettingsTabs = GUICtrlCreateTab(4, 26, 492, 20, $TCS_FIXEDWIDTH)
GUICtrlSetState($SettingsTabs, $GUI_HIDE)

Global $TabSwitcherGeneral = GUICtrlCreateLabel("General", 4, 26, 60, 20, $SS_SUNKEN +$SS_CENTER+ $SS_CENTERIMAGE)
GUICtrlSetBkColor($TabSwitcherGeneral, 0xf0f0f0)
GUICtrlSetColor($TabSwitcherGeneral, 0x000000)
GUICtrlSetOnEvent($TabSwitcherGeneral, "SettingsTabSwitch")
Global $TabSwitcherRecipes = GUICtrlCreateLabel("Recipes", 70, 26, 60, 20, $SS_SUNKEN +$SS_CENTER+ $SS_CENTERIMAGE)
GUICtrlSetBkColor($TabSwitcherRecipes, 0xf0f0f0)
GUICtrlSetColor($TabSwitcherRecipes, 0x000000)
GUICtrlSetOnEvent($TabSwitcherRecipes, "SettingsTabSwitch")
Global $TabSwitcherStyles = GUICtrlCreateLabel("Styles", 136, 26, 60, 20, $SS_SUNKEN +$SS_CENTER+ $SS_CENTERIMAGE)
GUICtrlSetBkColor($TabSwitcherStyles, 0xc0c0c0)
GUICtrlSetColor($TabSwitcherStyles, 0x000000)
GUICtrlSetOnEvent($TabSwitcherStyles, "SettingsTabSwitch")

Global $SettingsTabContentGeneral = GUICtrlCreateTabItem("General")
GUICtrlCreateLabel("label0", 30, 80, 50, 20)
GUICtrlCreateButton("OK0", 20, 50, 50, 20)
GUICtrlCreateInput("default", 80, 50, 70, 20)

Global $SettingsTabContentRecipes = GUICtrlCreateTabItem("Recipes")
GUICtrlCreateLabel("label1", 30, 80, 50, 20)
GUICtrlCreateCombo("", 20, 50, 60, 120)
GUICtrlSetData(-1, "Trids|CyberSlug|Larry|Jon|Tylo|guinness", "Jon") ; default Jon
GUICtrlCreateButton("OK1", 80, 50, 50, 20)

Global $SettingsTabContentStyles = GUICtrlCreateTabItem("Styles")
GUICtrlSetState(-1, $GUI_SHOW) ; will be display first
GUICtrlCreatePic(@ScriptDir & "\img\PoEGround.bmp", 6, 50, 486, 150)

; SAMPLE BACKGROUND
Global $SettingsSampleWindowBackground = GUICreate($WIN_TITLE & " Settings Sample Background", 486, 150, 9, 53, $WS_POPUP, BitOR($WS_EX_MDICHILD,$WS_EX_TRANSPARENT,$WS_EX_LAYERED), $SettingsWindow)
GUISetBkColor(0x000001)
_WinAPI_SetLayeredWindowAttributes($SettingsSampleWindowBackground, 0x000001, 1)
Global $SampleDropBackground = GUICtrlCreateGraphic((486-$BoxWidth)/2+1, (150-$BoxHeight)/2+1, $BoxWidth-2, $BoxHeight-2)
GUICtrlSetBkColor($SampleDropBackground, 0x000000)
; SAMPLE BORDER
Global $SettingsSampleWindowBorder = GUICreate($WIN_TITLE & " Settings Sample Border", 486, 150, 9, 53, $WS_POPUP, BitOR($WS_EX_MDICHILD,$WS_EX_TRANSPARENT,$WS_EX_LAYERED), $SettingsWindow)
GUISetBkColor(0xFFFFFE)
_WinAPI_SetLayeredWindowAttributes($SettingsSampleWindowBorder, 0xFFFFFE, 1)
Global $SampleDropBorder = GUICtrlCreateGraphic((486-$BoxWidth)/2, (150-$BoxHeight)/2, $BoxWidth, $BoxHeight)
GUICtrlSetColor($SampleDropBorder, 0xFFFFFF)
; SAMPLE TEXT
Global $SettingsSampleWindowText = GUICreate($WIN_TITLE & " Settings Sample Text", 486, 150, 9, 53, $WS_POPUP, BitOR($WS_EX_MDICHILD,$WS_EX_TRANSPARENT,$WS_EX_LAYERED), $SettingsWindow)
GUISetBkColor(0xFFFFFE)
_WinAPI_SetLayeredWindowAttributes($SettingsSampleWindowText, 0xFFFFFE, 1)
Global $SettingSampleTextLabel = GUICtrlCreateLabel("Orb of Transmutation", 0, 0, 486, 150, BitOR($SS_CENTER, $SS_CENTERIMAGE))
GUICtrlSetColor($SettingSampleTextLabel, 0xFFFFFF)
GUICtrlSetFont($SettingSampleTextLabel, $FontSize/2, 100, $GUI_FONTNORMAL, 'Fontin SmallCaps', $PROOF_QUALITY)
; Load
ReloadSample()

;Global $SampleDrop = GUICtrlCreateGraphic(20, 20, 200, 40)
;GUICtrlSetColor($SampleDrop, 0xFFFFFF)
;GUICtrlSetBkColor($SampleDrop, 0xFFFFFF)

;Global $SampleDropRect = GUICtrlSetGraphic($SampleDrop, $GUI_GR_RECT, 0, 0, 200, 40)
;GUICtrlSetColor($SampleDropRect, 0x4b4b4b)
;GUICtrlSetBkColor($SampleDropRect, 0x4b4b4b)

GUISwitch($SettingsWindow)
Global $TextGroupX = 10, $TextGroupY = 205
Global $TextGroup = GUICtrlCreateGroup("      Text", $TextGroupX, $TextGroupY, 150, 80) ; Group start
	; Clean style
	DllCall("UxTheme.dll", "int", "SetWindowTheme", "hwnd", GUICtrlGetHandle($TextGroup), "wstr", 0, "wstr", 0)
	; Set label colour
	GUICtrlSetColor($TextGroup, 0xF2F2F2)
	; Visibility toggle
	Global $TextVisibility = GUICtrlCreateCheckbox("", $TextGroupX+10, $TextGroupY, 15, 15)
	If $FontVisible Then
		GUICtrlSetState($TextVisibility, $GUI_CHECKED)
	EndIf
	; Colour label
	GUICtrlCreateLabel("Color:", $TextGroupX+10, $TextGroupY+25, 30, 24)
	GUICtrlSetColor(-1, 0xF2F2F2)
	; Colour code
	Global $TextColorCode = GUICtrlCreateInput("#000000", $TextGroupX+45, $TextGroupY+20, 50, 20)
	; Colour picker
	Global $TextPicker = _GUIColorPicker_Create('Pick', $TextGroupX+100, $TextGroupY+20, 40, 20, 0x000000, BitOR($CP_FLAG_DEFAULT, $CP_FLAG_CHOOSERBUTTON, $CP_FLAG_MAGNIFICATION), $aPalette, 13, 9)
	; Alpha label
	GUICtrlCreateLabel("Alpha:", $TextGroupX+10, $TextGroupY+50, 30, 24)
	GUICtrlSetColor(-1, 0xF2F2F2)
	; Transparency
	Global $TextTransparency = GUICtrlCreateInput("100", $TextGroupX+45, $TextGroupY+47, 50, 20, $ES_NUMBER)
	GUICtrlCreateUpdown($TextTransparency)
	GUICtrlSetLimit(-1, 255, 0)
GUICtrlCreateGroup("", -99, -99, 1, 1) ; Group end

Global $BorderGroupX = 175, $BorderGroupY = 205
Global $BorderGroup = GUICtrlCreateGroup("      Border", $BorderGroupX, $BorderGroupY, 150, 80) ; Group start
	; Clean style
	DllCall("UxTheme.dll", "int", "SetWindowTheme", "hwnd", GUICtrlGetHandle($BorderGroup), "wstr", 0, "wstr", 0)
	; Set label colour
	GUICtrlSetColor($BorderGroup, 0xF2F2F2)
	; Visibility toggle
	Global $BorderVisibility = GUICtrlCreateCheckbox("", $BorderGroupX+10, $BorderGroupY, 15, 15)
	If $BorderVisible Then
		GUICtrlSetState($BorderVisibility, $GUI_CHECKED)
	EndIf
	; Colour label
	GUICtrlCreateLabel("Color:", $BorderGroupX+10, $BorderGroupY+25, 30, 24)
	GUICtrlSetColor(-1, 0xF2F2F2)
	; Colour code
	Global $BorderColorCode = GUICtrlCreateInput("#000000", $BorderGroupX+45, $BorderGroupY+20, 50, 20)
	; Colour picker
	Global $BorderPicker = _GUIColorPicker_Create('Pick', $BorderGroupX+100, $BorderGroupY+20, 40, 20, 0x000000, BitOR($CP_FLAG_DEFAULT, $CP_FLAG_CHOOSERBUTTON, $CP_FLAG_MAGNIFICATION), $aPalette, 13, 9)
	; Alpha label
	GUICtrlCreateLabel("Alpha:", $BorderGroupX+10, $BorderGroupY+50, 30, 24)
	GUICtrlSetColor(-1, 0xF2F2F2)
	; Transparency
	Global $BorderTransparency = GUICtrlCreateInput("100", $BorderGroupX+45, $BorderGroupY+47, 50, 20, $ES_NUMBER)
	GUICtrlCreateUpdown($BorderTransparency)
	GUICtrlSetLimit(-1, 255, 0)
GUICtrlCreateGroup("", -99, -99, 1, 1) ; Group end

Global $BackgroundGroupX = 340, $BackgroundGroupY = 205
Global $BackgroundGroup = GUICtrlCreateGroup("      Background", $BackgroundGroupX, $BackgroundGroupY, 150, 80) ; Group start
	; Clean style
	DllCall("UxTheme.dll", "int", "SetWindowTheme", "hwnd", GUICtrlGetHandle($BackgroundGroup), "wstr", 0, "wstr", 0)
	; Set label colour
	GUICtrlSetColor($BackgroundGroup, 0xF2F2F2)
	; Visibility toggle
	Global $BackgroundVisibility = GUICtrlCreateCheckbox("", $BackgroundGroupX+10, $BackgroundGroupY, 15, 15)
	If $BgVisible Then
		GUICtrlSetState($BackgroundVisibility, $GUI_CHECKED)
	EndIf
	; Colour label
	GUICtrlCreateLabel("Color:", $BackgroundGroupX+10, $BackgroundGroupY+25, 30, 24)
	GUICtrlSetColor(-1, 0xF2F2F2)
	; Colour code
	Global $BackgroundColorCode = GUICtrlCreateInput("#000000", $BackgroundGroupX+45, $BackgroundGroupY+20, 50, 20)
	; Colour picker
	Global $BackgroundPicker = _GUIColorPicker_Create('Pick', $BackgroundGroupX+100, $BackgroundGroupY+20, 40, 20, 0x000000, BitOR($CP_FLAG_DEFAULT, $CP_FLAG_CHOOSERBUTTON, $CP_FLAG_MAGNIFICATION), $aPalette, 13, 9)
	; Alpha label
	GUICtrlCreateLabel("Alpha:", $BackgroundGroupX+10, $BackgroundGroupY+50, 30, 24)
	GUICtrlSetColor(-1, 0xF2F2F2)
	; Transparency
	Global $BackgroundTransparency = GUICtrlCreateInput("100", $BackgroundGroupX+45, $BackgroundGroupY+47, 50, 20, $ES_NUMBER)
	GUICtrlCreateUpdown($BackgroundTransparency)
	GUICtrlSetLimit(-1, 255, 0)
GUICtrlCreateGroup("", -99, -99, 1, 1) ; Group end

GUICtrlCreateLabel("Size:", 10, 290, 30, 24)
GUICtrlSetColor(-1, 0xF2F2F2)
Global $FontSlider = GUICtrlCreateSlider(50, 290, 430, 24)
DllCall("UxTheme.dll", "int", "SetWindowTheme", "hwnd", GUICtrlGetHandle($FontSlider), "wstr", 0, "wstr", 0)
GUICtrlSetBkColor($FontSlider, 0x000000)
GUICtrlSetLimit($FontSlider, 45, 18)

GUICtrlCreateTabItem("") ; end tabitem definition

; Bind window events
GUICtrlSetOnEvent($Button_Exit, "CloseApp")
GUICtrlSetOnEvent($Button_Minimize, "MinimizeApp")
GUICtrlSetOnEvent($Button_Anchor, "AnchorApp")
GUIRegisterMsg($WM_LBUTTONDOWN, "_WM_LBUTTONDOWN")
GuiCtrlSetOnEvent($FetchTabsButton, "FetchTabs")
GuiCtrlSetOnEvent($FetchTabContentButton, "FetchTabContent")
GUICtrlSetOnEvent($BackgroundPicker, "SetSampleBackgroundColor")
GUICtrlSetOnEvent($BorderPicker, "SetSampleBorderColor")
GUICtrlSetOnEvent($TextPicker, "SetSampleTextColor")
GUICtrlSetOnEvent($BackgroundColorCode, "SetSampleBackgroundColorCode")
GUICtrlSetOnEvent($BorderColorCode, "SetSampleBorderColorCode")
GUICtrlSetOnEvent($TextColorCode, "SetSampleTextColorCode")
GUICtrlSetOnEvent($TextTransparency, "SetSampleTextAlpha")
GUICtrlSetOnEvent($BackgroundTransparency, "SetSampleBgAlpha")
GUICtrlSetOnEvent($BorderTransparency, "SetSampleBorderAlpha")
GUICtrlSetOnEvent($TextVisibility, "SetSampleTextVisibility")
GUICtrlSetOnEvent($BorderVisibility, "SetSampleBorderVisibility")
GUICtrlSetOnEvent($BackgroundVisibility, "SetSampleBgVisibility")
GUICtrlSetOnEvent($FontSlider, "SetSampleFontSize")

; Show window
GUISetState(@SW_SHOW, $MainWindow)
GUISetState(@SW_SHOW, $MainTitleWindow)
WinSetTrans($WIN_TITLE, "", 200)
WinSetTrans($WIN_TITLE & " Title", "", 200)

; ############################## LOGIC ##############################

LoadLeagues()

If $ActiveLeagueName <> "" and $POESESSID <> "" Then
	FetchTabs()
EndIf

Global $Index = 0
Global $count = 0

Global $Path = "D:\SteamLibrary\steamapps\common\Path of Exile\logs\Client.txt"
Global $Count_Log = 0
Global $LogHandle = FileOpen($Path, $FO_READ)
While 1 ; main loop

	If $Scan Then
		Local $LogRows = FileReadToArray($LogHandle)

		If not @error Then
			#cs
			If not _ArrayDisplay($LogRows) Then ; debug new lines
				MsgBox($MB_OK, "show", @error)
			EndIf
			#ce

			For $i = 0 to UBound($LogRows) - 1
				If StringRegExp( $LogRows[$i], "(You have entered|Trade (cancelled|accepted))" ) Then
					$count += 1
					;ToolTip("count: " & $count & " for: " & $LogRows[$i], 0, 0)
					Sleep(1000)
					FetchTabContent()
					ExitLoop
				EndIf
			Next
		EndIf
	EndIf
	Sleep(1000)
WEnd
FileClose($LogHandle)

Func SetSampleFontSize()
	$FontSize = GUICtrlRead($FontSlider)
	ReloadSample()
EndFunc
Func SetSampleBackgroundColorCode()
	$BgColor = Dec(StringReplace(GUICtrlRead($BackgroundColorCode), "#", ""))
	GUICtrlSetData($BackgroundColorCode, '#' & Hex($BgColor,6))
	ReloadSample()
EndFunc
Func SetSampleBorderColorCode()
	$BorderColor = Dec(StringReplace(GUICtrlRead($BorderColorCode), "#", ""))
	GUICtrlSetData($BorderColorCode, '#' & Hex($BorderColor,6))
	ReloadSample()
EndFunc
Func SetSampleTextColorCode()
	$FontColor = Dec(StringReplace(GUICtrlRead($TextColorCode), "#", ""))
	GUICtrlSetData($TextColorCode, '#' & Hex($FontColor,6))
	ReloadSample()
EndFunc
Func SetSampleTextColor()
	$FontColor = _GUIColorPicker_GetColor($TextPicker, 0)
	GUICtrlSetData($TextColorCode, '#' & Hex($FontColor,6))
	ReloadSample()
EndFunc
Func SetSampleBorderColor()
	$BorderColor = _GUIColorPicker_GetColor($BorderPicker, 0)
	GUICtrlSetData($BorderColorCode, '#' & Hex($BorderColor,6))
	ReloadSample()
EndFunc
Func SetSampleBackgroundColor()
	$BgColor = _GUIColorPicker_GetColor($BackgroundPicker, 0)
	GUICtrlSetData($BackgroundColorCode, '#' & Hex($BgColor,6))
	ReloadSample()
EndFunc
Func SetSampleTextAlpha()
	If GUICtrlRead($TextTransparency) > 255 Then
		GUICtrlSetData($TextTransparency, 255)
	EndIf
	$FontAlpha = GUICtrlRead($TextTransparency)
	ReloadSample()
EndFunc
Func SetSampleBgAlpha()
	If GUICtrlRead($BackgroundTransparency) > 255 Then
		GUICtrlSetData($BackgroundTransparency, 255)
	EndIf
	$BgAlpha = GUICtrlRead($BackgroundTransparency)
	ReloadSample()
EndFunc
Func SetSampleBorderAlpha()
	If GUICtrlRead($BorderTransparency) > 255 Then
		GUICtrlSetData($BorderTransparency, 255)
	EndIf
	$BorderAlpha = GUICtrlRead($BorderTransparency)
	ReloadSample()
EndFunc
Func SetSampleTextVisibility()
	If GUICtrlRead($TextVisibility) == $GUI_CHECKED Then
		$FontVisible = true
	Else
		$FontVisible = false
	EndIf
	ReloadSample()
EndFunc
Func SetSampleBgVisibility()
	If GUICtrlRead($BackgroundVisibility) == $GUI_CHECKED Then
		$BgVisible = true
	Else
		$BgVisible = false
	EndIf
	ReloadSample()
EndFunc
Func SetSampleBorderVisibility()
	If GUICtrlRead($BorderVisibility) == $GUI_CHECKED Then
		$BorderVisible = true
	Else
		$BorderVisible = false
	EndIf
	ReloadSample()
EndFunc

Func ReloadSample()

	$BoxWidth = $FontSize*6.9 + 20
	$BoxHeight = $FontSize/2 + 20

	If $SettingsVisible And $BgVisible Then
		GUISetState(@SW_HIDE, $SettingsSampleWindowBackground)
		GUISetState(@SW_SHOW, $SettingsSampleWindowBackground)
	Else
		GUISetState(@SW_HIDE, $SettingsSampleWindowBackground)
	EndIf
	GUICtrlSetBkColor($SampleDropBackground, $BgColor)
	GUICtrlSetPos($SampleDropBackground, (486-$BoxWidth)/2+1, (150-$BoxHeight)/2+1, $BoxWidth-2, $BoxHeight-2)
	_WinAPI_SetLayeredWindowAttributes($SettingsSampleWindowBackground, 0x000001, $BgAlpha)

	If $SettingsVisible And $BorderVisible Then
		GUISetState(@SW_HIDE, $SettingsSampleWindowBorder)
		GUISetState(@SW_SHOW, $SettingsSampleWindowBorder)
	Else
		GUISetState(@SW_HIDE, $SettingsSampleWindowBorder)
	EndIf
	GUICtrlSetColor($SampleDropBorder, $BorderColor)
	GUICtrlSetPos($SampleDropBorder, (486-$BoxWidth)/2, (150-$BoxHeight)/2, $BoxWidth, $BoxHeight)
	_WinAPI_SetLayeredWindowAttributes($SettingsSampleWindowBorder, 0xFFFFFE, $BorderAlpha)

	If $SettingsVisible And $FontVisible Then
		GUISetState(@SW_HIDE, $SettingsSampleWindowText)
		GUISetState(@SW_SHOW, $SettingsSampleWindowText)
	Else
		GUISetState(@SW_HIDE, $SettingsSampleWindowText)
	EndIf
	GUICtrlSetColor($SettingSampleTextLabel, $FontColor)
	GUICtrlSetFont($SettingSampleTextLabel, $FontSize/2, 100, $GUI_FONTNORMAL, 'Fontin SmallCaps', $PROOF_QUALITY)
	_WinAPI_SetLayeredWindowAttributes($SettingsSampleWindowText, 0xFFFFFE, $FontAlpha)
EndFunc

Func SettingsTabSwitch()
	If @GUI_CtrlId == $TabSwitcherGeneral Then
		GUICtrlSetState($SettingsTabContentGeneral, $GUI_SHOW)
		GUICtrlSetBkColor($TabSwitcherGeneral, 0xc0c0c0)
		GUICtrlSetColor($TabSwitcherGeneral, 0x000000)
		GUICtrlSetBkColor($TabSwitcherRecipes, 0xf0f0f0)
		GUICtrlSetColor($TabSwitcherRecipes, 0x000000)
		GUICtrlSetBkColor($TabSwitcherStyles, 0xf0f0f0)
		GUICtrlSetColor($TabSwitcherStyles, 0x000000)
		GUISetState(@SW_HIDE, $SettingsSampleWindowBackground)
		GUISetState(@SW_HIDE, $SettingsSampleWindowBorder)
		GUISetState(@SW_HIDE, $SettingsSampleWindowText)
	ElseIf @GUI_CtrlId == $TabSwitcherRecipes Then
		GUICtrlSetState($SettingsTabContentRecipes, $GUI_SHOW)
		GUICtrlSetBkColor($TabSwitcherGeneral, 0xf0f0f0)
		GUICtrlSetColor($TabSwitcherGeneral, 0x000000)
		GUICtrlSetBkColor($TabSwitcherRecipes, 0xc0c0c0)
		GUICtrlSetColor($TabSwitcherRecipes, 0x000000)
		GUICtrlSetBkColor($TabSwitcherStyles, 0xf0f0f0)
		GUICtrlSetColor($TabSwitcherStyles, 0x000000)
		GUISetState(@SW_HIDE, $SettingsSampleWindowBackground)
		GUISetState(@SW_HIDE, $SettingsSampleWindowBorder)
		GUISetState(@SW_HIDE, $SettingsSampleWindowText)
	ElseIf @GUI_CtrlId == $TabSwitcherStyles Then
		GUICtrlSetState($SettingsTabContentStyles, $GUI_SHOW)
		GUICtrlSetBkColor($TabSwitcherGeneral, 0xf0f0f0)
		GUICtrlSetColor($TabSwitcherGeneral, 0x000000)
		GUICtrlSetBkColor($TabSwitcherRecipes, 0xf0f0f0)
		GUICtrlSetColor($TabSwitcherRecipes, 0x000000)
		GUICtrlSetBkColor($TabSwitcherStyles, 0xc0c0c0)
		GUICtrlSetColor($TabSwitcherStyles, 0x000000)
		ReloadSample()
	EndIf
EndFunc

Func SettingsVisibilityToggle()
	$SettingsVisible = Not $SettingsVisible
	If $SettingsVisible Then
		GUISetState(@SW_SHOW, $SettingsWindow)
		GUISetState(@SW_SHOW, $SettingsTitleWindow)
		If GUICtrlRead($SettingsTabs) == 2 Then
			ReloadSample()
		EndIf
	Else
		GUISetState(@SW_HIDE, $SettingsWindow)
		GUISetState(@SW_HIDE, $SettingsTitleWindow)
		GUISetState(@SW_HIDE, $SettingsSampleWindowBackground)
		GUISetState(@SW_HIDE, $SettingsSampleWindowBorder)
		GUISetState(@SW_HIDE, $SettingsSampleWindowText)
	EndIf
EndFunc

Func UpdateFilter()

	; Fetch bookmark strings from clean filter
	Local $CleanFilter = FileRead("C:\Users\Alvi\Documents\My Games\Path of Exile\LeagueStarter.filter")
	Local $FilterBookmark = StringRegExp($CleanFilter, "#(=)+(\r\n|\r|\n)# \[\[1000\]\] OVERRIDE AREA 2(.)+(\r\n|\r|\n)#(=)+(\r\n|\r|\n)", $STR_REGEXPARRAYGLOBALFULLMATCH )
	Local $FilterBookmarkRares = $FilterBookmark[0]

	Local $FilterChaosSetBlock = ''

	$FilterChaosSetBlock &= GetChaosRuleBlock($AmuletVisible, 'amulets', '"Amulets"', '', 60, 1, 1, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($RingVisible, 'rings', '"Rings"', '', 60, 1, 1, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($BeltVisible, 'belts', '"Belts"', '"Chain Belt" "Rustic Sash" "Heavy Belt" "Leather Belt" "Cloth Belt" "Studded Belt"', 60, 2, 1, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($HelmetVisible, 'helmets', '"Helmets"', '', 60, 2, 2, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($BodyVisible, 'chests', '"Body Armour"', '', 60, 2, 3, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($GlovesVisible, 'gloves', '"Gloves"', '', 60, 2, 2, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($BootsVisible, 'boots', '"Boots"', '', 60, 2, 2, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')
	$FilterChaosSetBlock &= GetChaosRuleBlock($WeaponVisible, 'weapons', '"Daggers" "Wands" "Swords" "Axes" "Maces" "Sceptres"', '', 60, 1, 3, 25, '255 0 0 255', '255 0 0 255', '0 0 200 150')

	; Create new filter
	Local $UpdatedFilter = $CleanFilter
	$UpdatedFilter = StringReplace($UpdatedFilter, $FilterBookmarkRares[0], $FilterBookmarkRares[0] & _
	@CRLF & "#>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" & @CRLF & "# PoE Easy Mapping rules - start" & @CRLF & "#>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>" & _
	@CRLF & @CRLF & $FilterChaosSetBlock & @CRLF & @CRLF & "#<<<<<<<<<<<<<<<<<<<<<<<<<<<<<" & @CRLF & "# PoE Easy Mapping rules - end" & _
	@CRLF & "#<<<<<<<<<<<<<<<<<<<<<<<<<<<<<" & @CRLF)

	; Write changes to file
	Local $NewFilterFileName = "C:\Users\Alvi\Documents\My Games\Path of Exile\PoEEM.filter"
	Local $NewFilterFileHandle = FileOpen($NewFilterFileName, $FO_OVERWRITE)
	FileWrite($NewFilterFileName, $UpdatedFilter)
	FileClose($NewFilterFileHandle)

EndFunc

Func GetChaosRuleBlock($isVisible, $filterName, $filterClasses, $filterBaseTypes, $filteriLvl, $filterWidth, $filterHeight, $filterFontSize, $filterTextColor, $filterBorderColor, $filterBackgroundColor)
	Local $RuleSet = ""
	If $isVisible Then
		$RuleSet &= @CRLF & "Show # chaos set - " & $filterName
		If $filterClasses <> '' Then
			$RuleSet &= @CRLF & "	Class " & $filterClasses
		EndIf
		If $filterBaseTypes <> '' Then
		$RuleSet &= @CRLF & "	BaseType " & $filterBaseTypes
		EndIf
		$RuleSet &= @CRLF & "	Identified False"
		$RuleSet &= @CRLF & "	ElderItem False"
		$RuleSet &= @CRLF & "	ShaperItem False"
		$RuleSet &= @CRLF & "	ItemLevel >= " & $filteriLvl
		$RuleSet &= @CRLF & "	Rarity = Rare"
		$RuleSet &= @CRLF & "	Width = " & $filterWidth
		$RuleSet &= @CRLF & "	Height = " & $filterHeight
		$RuleSet &= @CRLF & "	SetFontSize " & $filterFontSize
		$RuleSet &= @CRLF & "	SetTextColor " & $filterTextColor
		$RuleSet &= @CRLF & "	SetBorderColor " & $filterBorderColor
		$RuleSet &= @CRLF & "	SetBackgroundColor " & $filterBackgroundColor
		$RuleSet &= @CRLF & "	DisableDropSound" & @CRLF
	Else
		$RuleSet &= @CRLF & "Hide # chaos set - " & $filterName
		If $filterClasses <> '' Then
			$RuleSet &= @CRLF & "	Class " & $filterClasses
		EndIf
		If $filterBaseTypes <> '' Then
		$RuleSet &= @CRLF & "	BaseType " & $filterBaseTypes
		EndIf
		$RuleSet &= @CRLF & "	Identified False"
		$RuleSet &= @CRLF & "	ElderItem False"
		$RuleSet &= @CRLF & "	ShaperItem False"
		$RuleSet &= @CRLF & "	ItemLevel >= " & $filteriLvl
		$RuleSet &= @CRLF & "	Rarity = Rare"
		$RuleSet &= @CRLF & "	Width = " & $filterWidth
		$RuleSet &= @CRLF & "	Height = " & $filterHeight
		$RuleSet &= @CRLF & "	DisableDropSound" & @CRLF
	EndIf

	Return $RuleSet
EndFunc

Func TabVisibilityToggle()
	$TabsVisible = Not $TabsVisible
	If $TabsVisible Then
		WinMove($WIN_TITLE & " Tabs", "", 100, 100, _Max(250, 250*$UserTabs.Count), 250)
		WinMove($WIN_TITLE & " Tabs Content", "", 100, 100, _Max(250, 250*$UserTabs.Count), 250)
		GUISetState(@SW_SHOW, $TabsHandleWindow)
		GUISetState(@SW_SHOW, $TabsWindow)
		WinSetTrans($WIN_TITLE & " Tabs", "", 1)
		WinSetTrans($WIN_TITLE & " Tabs Content", "", 200)
		

		Local $graphic = _GDIPlus_GraphicsCreateFromHWND($TabsWindow)
		Local $n = 0
		For $UserTab In $UserTabs
			Local $img = _GDIPlus_ImageLoadFromFile(@ScriptDir & "\img\12x12grid.jpg")
			$img = _GDIPlus_ImageResize($img, 250, 250)
			_GDIPlus_GraphicsDrawImage($graphic, $img, $n*250, 0)
			For $item In $UserTab.Item("items")
				$img = _GDIPlus_ImageLoadFromFile(_GetURLImage($item.Item("img")))
				$img = _GDIPlus_ImageResize($img, $item.Item("w") * (250/12), $item.Item("h") * (250/12) )
				_GDIPlus_GraphicsDrawImage($graphic, $img, $n*250 + ( $item.Item("x") * (250/12) ), ( $item.Item("y") * (250/12) ) )
			Next
			$n += 1
		Next
	Else
		GUISetState(@SW_HIDE, $TabsHandleWindow)
		GUISetState(@SW_HIDE, $TabsWindow)
	EndIf
EndFunc

Func FetchTabs()
	IniWrite($INI_PATH, "Inspector", "ActiveLeague", GUICtrlRead($LeagueComboBox))
	IniWrite($INI_PATH, "Inspector", "POESESSID", GUICtrlRead($POESESSIDInput))

	If $Username == "" Then
		$Username = GetUsername()
	EndIf
	Local $ActiveLeagueName = GUICtrlRead($LeagueComboBox)

	If $Username <> "" Then
		; Download and parse the user's username
		Local $postData = ""
		Local $reqHeaders = ObjCreate("System.Collections.ArrayList")
		Local $options = "\nRequestType: GET"
		$reqHeaders.Add("Cookie: POESESSID=" & $POESESSID)
		Local $UserTabsJSON = FetchUrlContent("https://www.pathofexile.com/character-window/get-stash-items?accountName=" & $Username & "&league=" & $ActiveLeagueName & "&tabs=1", $postData, $reqHeaders, $options)
		Local $Tabs = _JSONDecode($UserTabsJSON)

		Local $LeagueTabs = ObjCreate("Scripting.Dictionary")
		Local $numTabs = _JSONGet($Tabs, "numTabs")
		$Tabs = _JSONGet($Tabs, "tabs")
		If not _JSONIsNull($Tabs) Then

			_GUICtrlListView_DeleteAllItems($TabListView)

			For $tab in $Tabs
				; name:		tab name
				; index:	tab index
				; id:		tab id
				; type:		tab type. Supported tab types: NormalStash, PremiumStash
				; checked:	tab has been checked as active by the user
				Local $tabObj = ObjCreate("Scripting.Dictionary")
				$tabObj.Add( "id", _JSONGet($tab, "id") )
				$tabObj.Add( "name", _JSONGet($tab, "n") )
				$tabObj.Add( "index", _JSONGet($tab, "i") )
				$tabObj.Add( "type", _JSONGet($tab, "type") )
				$tabObj.Add( "checked", false )

				If $tabObj.Item("type") == "NormalStash" or $tabObj.Item("type") == "PremiumStash" Then
					$LeagueTabs.Add( $tabObj.Item("id"), $tabObj )

					GUICtrlCreateListViewItem($tabObj.Item("name") & "|" & $tabObj.Item("id") & "|" & $tabObj.Item("index"), $TabListView)
				EndIf
			Next

			_GUICtrlListView_SetColumnWidth($TabListView, 0, 180)
			_GUICtrlListView_SetColumnWidth($TabListView, 1, 0)
			_GUICtrlListView_SetColumnWidth($TabListView, 2, 0)

			SelectSavedTabs()
		Else
			MsgBox(BitOr($MB_OK,$MB_ICONERROR), "No tabs found", "No tabs found")
		EndIf
	Else
		MsgBox(BitOr($MB_OK,$MB_ICONERROR), "Invalid POESESSID", "Invalid POESESSID")
	EndIf
EndFunc

Func SelectSavedTabs()
	Local $SavedSelectedTabs = IniRead($INI_PATH, "Inspector", "SelectedTabs", "")
	$SavedSelectedTabs = StringSplit($SavedSelectedTabs, "|")

    For $i = 0 To _GUICtrlListView_GetItemCount($TabListView) - 1
    	Local $row = _GUICtrlListView_GetItemTextArray($TabListView, $i)
		If _ArraySearch($SavedSelectedTabs, $row[2]) > 0 Then
			_GUICtrlListView_SetItemChecked($TabListView, $i)
		EndIf
	Next
EndFunc

Func _GetURLImage($sURL, $sDirectory = @TempDir)
	Local $hDownload, $sFile, $sDirectory
	$sFile = StringRegExpReplace($sURL, "^.*/", "")
	$sFile = StringRegExpReplace($sFile, "\?.*$", "")
	If @error Then
	  Return SetError(1, 0, $sFile)
	EndIf
	If StringRight($sDirectory, 1) <> "\" Then
	  $sDirectory = $sDirectory & "\"
	EndIf
	$sDirectory = $sDirectory & $sFile
	If FileExists($sDirectory) Then
	  Return $sDirectory
	EndIf
	;ToolTip($sDirectory, 0, 0)
	$hDownload = InetGet($sURL, $sDirectory, 17, 1)
	While InetGetInfo($hDownload, 2) = False
	  If InetGetInfo($hDownload, 4) <> 0 Then
	   InetClose($hDownload)
	   Return SetError(1, 0, $sDirectory)
	  EndIf
	  Sleep(10)
	WEnd
	InetClose($hDownload)
	Return $sDirectory
EndFunc   ;==>_GetURLImage

Func FetchTabContent()

	$SelectedTabIDs = _ArrayToString(_GUICtrlListView_GetCheckedStates($TabListView, 2).ToArray(), "|")
	IniWrite($INI_PATH, "Inspector", "SelectedTabs", $SelectedTabIDs)
	$SelectedTabIndexes = _GUICtrlListView_GetCheckedStates($TabListView, 3)

	If $SelectedTabIndexes.Count > 0 Then
		Local $chaos = ObjCreate("Scripting.Dictionary")
		$chaos.Add("helmet", 0)
		$chaos.Add("chest", 0)
		$chaos.Add("gloves", 0)
		$chaos.Add("boots", 0)
		$chaos.Add("weapon", 0)
		$chaos.Add("belt", 0)
		$chaos.Add("amulet", 0)
		$chaos.Add("ring", 0)

		Local $regal = ObjCreate("Scripting.Dictionary")
		$regal.Add("helmet", 0)
		$regal.Add("chest", 0)
		$regal.Add("gloves", 0)
		$regal.Add("boots", 0)
		$regal.Add("weapon", 0)
		$regal.Add("belt", 0)
		$regal.Add("amulet", 0)
		$regal.Add("ring", 0)

		Local $UserTabs = ObjCreate("System.Collections.ArrayList")

		For $tabIndex in $SelectedTabIndexes
			Local $postData = ""
			Local $reqHeaders = ObjCreate("System.Collections.ArrayList")
			Local $options = "\nRequestType: GET"
			$reqHeaders.Add("Cookie: POESESSID=" & $POESESSID)
			Local $TabContentJSON = FetchUrlContent("https://www.pathofexile.com/character-window/get-stash-items?accountName=" & $Username & "&tabIndex=" & $tabIndex & "&league=" & $ActiveLeagueName & "&tabs=0", $postData, $reqHeaders, $options)
			Local $TabContent = _JSONDecode($TabContentJSON)

			$UserTab = ObjCreate("Scripting.Dictionary")
			$UserTab.Add("index", $tabIndex)
			Local $tabItems = ObjCreate("System.Collections.ArrayList")

			For $item in _JSONGet($TabContent, "items")
				Local $ilvl = _JSONGet($item, "ilvl")
				Local $rarity = _JSONGet($item, "frameType")
				Local $identified = _JSONGet($item, "identified")
				Local $class = GetItemClassFromCategory(_JSONGet($item, "category"))

				;ToLog($ilvl & ", " & $rarity & ", " & $identified & ", " & $class)
				If $class <> "" Then
					If $ilvl >= 60 and $ilvl < 75 and $rarity = 2 and $identified = 0 Then
						$chaos.Item($class) += 1
					ElseIf $ilvl >= 60 and $ilvl < 75 and $rarity = 2 and $identified = 1 Then
						$chaos.Item($class) += 1
					ElseIf $ilvl >= 75 and $rarity = 2 and $identified = 0 Then
						$regal.Item($class) += 1
					ElseIf $ilvl >= 75 and $rarity = 2 and $identified = 1 Then
						$regal.Item($class) += 1
					EndIf
				
					Local $tabItem = ObjCreate("Scripting.Dictionary")
					$tabItem.Add("img", _JSONGet($item, "icon"))
					$tabItem.Add("x", _JSONGet($item, "x"))
					$tabItem.Add("y", _JSONGet($item, "y"))
					$tabItem.Add("w", _JSONGet($item, "w"))
					$tabItem.Add("h", _JSONGet($item, "h"))
					$tabItems.Add($tabItem)
				EndIf
			Next

			$UserTab.Add("items", $tabItems)
			$UserTabs.Add($UserTab)
		Next
		
		#cs
		GUICtrlSetData($ChaosHelmetsLabel, _Max(0, 12 - ($chaos.Item("helmet") + $regal.Item("helmet"))))
		GUICtrlSetData($ChaosChestsLabel, _Max(0, 12 - ($chaos.Item("chest") + $regal.Item("chest"))))
		GUICtrlSetData($ChaosGlovesLabel, _Max(0, 12 - ($chaos.Item("gloves") + $regal.Item("gloves"))))
		GUICtrlSetData($ChaosBootsLabel, _Max(0, 12 - ($chaos.Item("boots") + $regal.Item("boots"))))
		GUICtrlSetData($ChaosWeaponsLabel, _Max(0, 24 - ($chaos.Item("weapon") + $regal.Item("weapon"))))
		GUICtrlSetData($ChaosBeltsLabel, _Max(0, 999 - ($chaos.Item("belt") + $regal.Item("belt"))))
		GUICtrlSetData($ChaosAmuletsLabel, _Max(0, 999 - ($chaos.Item("amulet") + $regal.Item("amulet"))))
		GUICtrlSetData($ChaosRingsLabel, _Max(0, 999 - ($chaos.Item("ring") + $regal.Item("ring"))))
		#ce

		;GUICtrlSetData($RegalHelmetsLabel, $regal.Item("helmet"))
		;GUICtrlSetData($RegalChestsLabel, $regal.Item("chest"))
		;GUICtrlSetData($RegalGlovesLabel, $regal.Item("gloves"))
		;GUICtrlSetData($RegalBootsLabel, $regal.Item("boots"))
		;GUICtrlSetData($RegalWeaponsLabel, $regal.Item("weapon"))
		;GUICtrlSetData($RegalBeltsLabel, $regal.Item("belt"))
		;GUICtrlSetData($RegalAmuletsLabel, $regal.Item("amulet"))
		;GUICtrlSetData($RegalRingsLabel, $regal.Item("ring"))
	EndIf
EndFunc

Func GetItemClassFromCategory($category)

	#cs
	category.accessories[0] = ring
	category.accessories[0] = belt
	category.accessories[0] = amulet
	category.armour[0] = helmet
	category.armour[0] = chest
	category.armour[0] = boots
	category.armour[0] = gloves
	category.weapons[0] = wand
	category.weapons[0] = onesword
	category.weapons[0] = onemace
	category.weapons[0] = dagger
	category.weapons[0] = sceptre
	category.weapons[0] = oneaxe
	#ce

	If not _JSONIsNull(_JSONGet($category, "accessories")) Then
		Return _JSONGet($category, "accessories")[0]
	ElseIf not _JSONIsNull(_JSONGet($category, "armour")) Then
		Return _JSONGet($category, "armour")[0]
	ElseIf not _JSONIsNull(_JSONGet($category, "weapons")) Then
		Return "weapon"
	EndIf
	Return ""
EndFunc

Func _GUICtrlListView_GetCheckedStates($idListview, $indexColumn = 1)
    Local $return = ObjCreate("System.Collections.ArrayList")
    For $i = 0 To _GUICtrlListView_GetItemCount($idListview) - 1
        If _GUICtrlListView_GetItemChecked($idListview, $i) Then
        	Local $row = _GUICtrlListView_GetItemTextArray($idListview, $i)
            $return.Add($row[$indexColumn])
        EndIf
    Next
    Return $return
EndFunc

Func GetUsername()
	Local $POESESSID = GUICtrlRead($POESESSIDInput)

	; Download and parse the user's username
	Local $postData = ""
	Local $reqHeaders = ObjCreate("System.Collections.ArrayList")
	Local $options = "\nRequestType: GET"
	$reqHeaders.Add("Cookie: POESESSID=" & $POESESSID)
	Local $AccountPageMarkup = FetchUrlContent("https://www.pathofexile.com/my-account", $postData, $reqHeaders, $options)

	Local $Matches = StringRegExp($AccountPageMarkup, "(?iU)<h1 class=""name"">(.*)</h1>", $STR_REGEXPARRAYMATCH)

	If ubound($Matches) > 0 Then
		Return $Matches[0]
	Else
		Return ""
	EndIf
EndFunc

Func LoadLeagues()
	; Download and parse the current leagues
	Local $postData = ""
	Local $reqHeaders = ObjCreate("System.Collections.ArrayList")
	Local $options = "\nRequestType: GET"
	$reqHeaders.Add("Host: api.pathofexile.com")
	$reqHeaders.Add("Connection: keep-alive")
	$reqHeaders.Add("Cache-Control: max-age=0")
	$reqHeaders.Add("Content-type: application/x-www-form-urlencoded; charset=UTF-8")
	$reqHeaders.Add("Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8")
	$reqHeaders.Add("User-Agent: Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.90 Safari/537.36")
	Local $leagueJSON = FetchUrlContent("http://api.pathofexile.com/leagues?type=main&compact=1", $postData, $reqHeaders, $options)
	Local $LeagueData = _JSONDecode($leagueJSON)

	If IsArray($LeagueData) Then
		Local $hardcore = "hardcore"
		Local $standard = "standard"
		Local $leagueDropDownNames = ""
		Local $leagues = ObjCreate("Scripting.Dictionary")

		Local $selected = ""

		For $league in $leagueData
			Local $leagueId = _JSONGet($league, "id")

			If not _JSONGet($league, "event") and not StringRegExp($leagueId, "(?i)^SSF") Then
				If $leagueId = $standard Then
					$leagues.Add("standard", $leagueId)
				ElseIf $leagueId = $hardcore Then
					$leagues.Add("hardcore", $leagueId)
				ElseIf StringInStr($leagueId, $hardcore) Then
					$leagues.Add("tmphardcore", $leagueId)
				Else
					$leagues.Add("tmpstandard", $leagueId)
				EndIf
				If $ActiveLeagueName <> "" and $ActiveLeagueName == $leagueId Then
					$selected = $leagueId
				EndIf

				$leagueDropDownNames &= $leagueId & "|"
			EndIf
		Next
		$leagueDropDownNames = StringTrimRight($leagueDropDownNames, 1)

		If $selected == "" Then
			$selected = $leagues.Item("standard")
		EndIf
		GUICtrlSetData($LeagueComboBox, $leagueDropDownNames, $selected)
	Else
		MsgBox(BitOr($MB_OK,$MB_ICONERROR), "Error fetching leagues", "Error fetching leagues")
	EndIf
EndFunc

Func _WM_LBUTTONDOWN($hWnd, $iMsg, $wParam, $lParam)
	; ToolTip($hWnd)
	If $hWnd == $MainWindow Or $hWnd == $SettingsWindow Then
    	_SendMessage($hWnd, $WM_SYSCOMMAND, $SC_DRAGMOVE, 0)
	EndIf
EndFunc

Func _WM_LBUTTONUP($hWnd, $iMsg, $wParam, $lParam)
    MsgBox($MB_OK, "", "up")
EndFunc

Func CloseApp()
	Local $winPos = WinGetPos($WIN_TITLE)
	IniWrite($INI_PATH, "General", "WindowX", $winPos[0])
	IniWrite($INI_PATH, "General", "WindowY", $winPos[1])
	Exit
EndFunc

Func ToLog($text = "")
	_FileWriteLog ( @ScriptDir & "\log.txt", $text )
EndFunc

Func MinimizeApp()
	GUISetState(@SW_MINIMIZE, $MainWindow)
EndFunc

Func AnchorApp()
	$TabsHandleActive = Not $TabsHandleActive
	If $TabsHandleActive Then
		$winPos = WinGetPos($WIN_TITLE)
		WinMove($WIN_TITLE, "", $winPos[0], $winPos[1], 512, 64)
		;GUISetState(@SW_SHOW, $TabsHandleWindow)
	Else
		$winPos = WinGetPos($WIN_TITLE)
		WinMove($WIN_TITLE, "", $winPos[0], $winPos[1], 512, 24)
		;GUISetState(@SW_HIDE, $TabsHandleWindow)
	EndIf
EndFunc

Func MainVisibilityToggle()
	$MainVisible = Not $MainVisible
	If $MainVisible Then
		GUICtrlSetImage ($MainVisibilityToggleButton, @ScriptDir & "\img\Visibility_ON.bmp")
	Else
		GUICtrlSetImage ($MainVisibilityToggleButton, @ScriptDir & "\img\Visibility_OFF.bmp")
	EndIf
EndFunc

Func ClassVisibilityToggle()
	Local $img = ""
	Switch @GUI_CtrlId
		Case $AmuletVisibilityToggleButton
			$AmuletVisible = not $AmuletVisible
			If $AmuletVisible Then
				$img = "\Amulet_ON.bmp"
			Else
				$img = "\Amulet_OFF.bmp"
			EndIf
		Case $RingVisibilityToggleButton
			$RingVisible = not $RingVisible
			If $RingVisible Then
				$img = "\Ring_ON.bmp"
			Else
				$img = "\Ring_OFF.bmp"
			EndIf
		Case $BeltVisibilityToggleButton
			$BeltVisible = not $BeltVisible
			If $BeltVisible Then
				$img = "\Belt_ON.bmp"
			Else
				$img = "\Belt_OFF.bmp"
			EndIf
		Case $HelmetVisibilityToggleButton
			$HelmetVisible = not $HelmetVisible
			If $HelmetVisible Then
				$img = "\Helmet_ON.bmp"
			Else
				$img = "\Helmet_OFF.bmp"
			EndIf
		Case $BodyVisibilityToggleButton
			$BodyVisible = not $BodyVisible
			If $BodyVisible Then
				$img = "\Body_ON.bmp"
			Else
				$img = "\Body_OFF.bmp"
			EndIf
		Case $GlovesVisibilityToggleButton
			$GlovesVisible = not $GlovesVisible
			If $GlovesVisible Then
				$img = "\Gloves_ON.bmp"
			Else
				$img = "\Gloves_OFF.bmp"
			EndIf
		Case $BootsVisibilityToggleButton
			$BootsVisible = not $BootsVisible
			If $BootsVisible Then
				$img = "\Boots_ON.bmp"
			Else
				$img = "\Boots_OFF.bmp"
			EndIf
		Case $WeaponVisibilityToggleButton
			$WeaponVisible = not $WeaponVisible
			If $WeaponVisible Then
				$img = "\Weapon_ON.bmp"
			Else
				$img = "\Weapon_OFF.bmp"
			EndIf
	EndSwitch
	If $img Then
		GUICtrlSetImage (@GUI_CtrlId, @ScriptDir & "\img" & $img)
		UpdateFilter()
	EndIf
EndFunc
