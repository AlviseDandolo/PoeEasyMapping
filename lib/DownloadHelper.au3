#include-once

Func FetchUrlContent($url, $ioData, $ioHdr, $options)

	#cs ----------------------------------------------------------------------------
		url		= download url
		ioData	= uri encoded postData 
		ioHdr	= array of request headers
		options	= multiple options separated by newline (currently only "SaveAs:",  "Redirect:true/false")
	#ce ----------------------------------------------------------------------------

	Local $sOutput = ""

	; parse options, create the cURL request and execute it
	Local $curl = @ScriptDir & "\lib\curl.exe"
	Local $headers = ""
	Local $cookies = ""
	For $val In $ioHdr
		$val = StringRegExpReplace($val, "(?i)(.*?)\s*:\s*(.*)", "$1:$2")
		Local $match = StringRegExp($val, "(?i)^Cookie:(.*)", $STR_REGEXPARRAYMATCH )
		If ubound($match) > 0 Then
			$cookies &= $match[0]
		Else
			$headers &= " -H """ & $val & """"
		EndIf
	Next

	Local $path = $curl & " -ks " & $url & " " & $headers
	If $cookies <> "" Then
		$path &= "-b " & "" & $cookies & ""
	EndIf
	Local $iPID = Run($path, "", @SW_HIDE, $STDERR_MERGED )
	ProcessWaitClose($iPID)
	Local $output = StdoutRead($iPID, True)

	Return $output
EndFunc