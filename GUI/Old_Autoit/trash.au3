
#include <Constants.au3>
#include <ButtonConstants.au3>
#include <GUIConstantsEx.au3>
#include <StaticConstants.au3>
#include <WindowsConstants.au3>
#include <ColorConstantS.au3>
#include <FontConstants.au3>
#include "ColorConstants.au3"

Opt("GUIOnEventMode", 1)

$GUI = GUICreate("GUI", 250, 300)
GUISetOnEvent($GUI_EVENT_CLOSE, "_Exit")

$Button = GUICtrlCreateButton("Button", 160, 185, 85, 110, $SS_CENTER) ; $BS_MULTILINE, $BS_CENTER, $BS_VCENTER, $WS_EX_WINDOWEDGE))
GUICtrlSetBkColor(-1, 0xFFFFFF)
GUICtrlSetFont($Button, 14, 800, 0, "calibri", 5)
GUICtrlSetColor($Button, 0x00000)
GUICtrlSetOnEvent($Button, "_Exit")

GUISetState()

While 1
    Sleep(100)
WEnd

Func _Exit()
    Exit
EndFunc   ;==>_Exit