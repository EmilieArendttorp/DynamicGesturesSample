# DynamicGesturesSample

This Unity project includes a scene with a dynamic gesture linked to the static pointing gesture.

To record a new gesture, the "Debug Mode" in the "Gesture Manager" component must be enabled, and the correct hand (OVRSkeleton) must be dragged into the "Rec Skeleton" field.
If this is done correctly, one can record a new static gesture by pressing 'Space' and a new static+dynamic gesture by holding down 'd' until the gesture is completed.
This will only save the gestures at runtime!!! To save it between play, one must copy the list of gesture while in runtime and paste them into the list again out of runtime.

Have fun :)
