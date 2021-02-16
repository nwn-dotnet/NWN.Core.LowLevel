//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public unsafe class CNWSWaypoint : CNWSObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CNWSWaypoint(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSWaypoint_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSWaypoint(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CNWSWaypoint_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSWaypoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSWaypoint(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      base.Dispose(disposing);
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSWaypoint self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSWaypoint self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSWaypoint other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSWaypoint other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSWaypoint left, CNWSWaypoint right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSWaypoint left, CNWSWaypoint right) {
    return !Equals(left, right);
  }

  public int m_bMapNote {
    set {
      NWNXLibPINVOKE.CNWSWaypoint_m_bMapNote_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSWaypoint_m_bMapNote_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bMapNoteEnabled {
    set {
      NWNXLibPINVOKE.CNWSWaypoint_m_bMapNoteEnabled_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSWaypoint_m_bMapNoteEnabled_get(swigCPtr);
      return ret;
    } 
  }

  public CExoLocString m_szMapNote {
    set {
      NWNXLibPINVOKE.CNWSWaypoint_m_szMapNote_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSWaypoint_m_szMapNote_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CExoLocString m_sLocalizedName {
    set {
      NWNXLibPINVOKE.CNWSWaypoint_m_sLocalizedName_set(swigCPtr, CExoLocString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSWaypoint_m_sLocalizedName_get(swigCPtr);
      CExoLocString ret = (cPtr == global::System.IntPtr.Zero) ? null : new CExoLocString(cPtr, false);
      return ret;
    } 
  }

  public CNWSWaypoint(uint oidId) : this(NWNXLibPINVOKE.new_CNWSWaypoint__SWIG_0(oidId), true) {
  }

  public CNWSWaypoint() : this(NWNXLibPINVOKE.new_CNWSWaypoint__SWIG_1(), true) {
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ, int bRunScripts) {
    NWNXLibPINVOKE.CNWSWaypoint_AddToArea__SWIG_0(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ, bRunScripts);
  }

  public void AddToArea(CNWSArea pArea, float fX, float fY, float fZ) {
    NWNXLibPINVOKE.CNWSWaypoint_AddToArea__SWIG_1(swigCPtr, CNWSArea.getCPtr(pArea), fX, fY, fZ);
  }

  public override void AIUpdate() {
    NWNXLibPINVOKE.CNWSWaypoint_AIUpdate(swigCPtr);
  }

  public override CNWSWaypoint AsNWSWaypoint() {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWSWaypoint_AsNWSWaypoint(swigCPtr);
    CNWSWaypoint ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWSWaypoint(cPtr, false);
    return ret;
  }

  public override void EventHandler(uint nEventId, uint nCallerObjectId, void* pScript, uint nCalendarDay, uint nTimeOfDay) {
    NWNXLibPINVOKE.CNWSWaypoint_EventHandler(swigCPtr, nEventId, nCallerObjectId, (global::System.IntPtr)pScript, nCalendarDay, nTimeOfDay);
  }

  public void RemoveFromArea() {
    NWNXLibPINVOKE.CNWSWaypoint_RemoveFromArea(swigCPtr);
  }

  public int LoadFromTemplate(CResRef cResRef, CExoString pTag) {
    int ret = NWNXLibPINVOKE.CNWSWaypoint_LoadFromTemplate__SWIG_0(swigCPtr, CResRef.getCPtr(cResRef), CExoString.getCPtr(pTag));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadFromTemplate(CResRef cResRef) {
    int ret = NWNXLibPINVOKE.CNWSWaypoint_LoadFromTemplate__SWIG_1(swigCPtr, CResRef.getCPtr(cResRef));
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int LoadWaypoint(CResGFF pRes, CResStruct cWaypointStruct, CExoString pTag) {
    int ret = NWNXLibPINVOKE.CNWSWaypoint_LoadWaypoint__SWIG_0(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cWaypointStruct), CExoString.getCPtr(pTag));
    return ret;
  }

  public int LoadWaypoint(CResGFF pRes, CResStruct cWaypointStruct) {
    int ret = NWNXLibPINVOKE.CNWSWaypoint_LoadWaypoint__SWIG_1(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cWaypointStruct));
    return ret;
  }

  public int SaveWaypoint(CResGFF pRes, CResStruct cWaypointStruct) {
    int ret = NWNXLibPINVOKE.CNWSWaypoint_SaveWaypoint(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(cWaypointStruct));
    return ret;
  }

}

}
