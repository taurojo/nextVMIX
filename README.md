# nextVMIX
Send next play item, in Vmix.

This code retrieves the currently active clip from an XML response using the SelectSingleNode method, which searches for the specified XML node. It then converts the active clip value to an integer using Convert.ToInt32 method and increments it by 1.

Finally, it calls the api.Function method with the "Fade" function as a parameter and the incremented active clip value as the input. This causes the next clip to be faded in or transitioned to using a fader. If a different function is used, such as "Cut", the next clip would be transitioned to immediately without a fader effect.
