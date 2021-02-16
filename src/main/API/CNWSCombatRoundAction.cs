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

public unsafe class CNWSCombatRoundAction : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSCombatRoundAction(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSCombatRoundAction(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSCombatRoundAction obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSCombatRoundAction() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CNWSCombatRoundAction(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static unsafe implicit operator void*(CNWSCombatRoundAction self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSCombatRoundAction self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSCombatRoundAction other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSCombatRoundAction other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSCombatRoundAction left, CNWSCombatRoundAction right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSCombatRoundAction left, CNWSCombatRoundAction right) {
    return !Equals(left, right);
  }

  public int m_nActionTimer {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionTimer_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionTimer_get(swigCPtr);
      return ret;
    } 
  }

  public ushort m_nAnimation {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimation_set(swigCPtr, value);
    } 
    get {
      ushort ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimation_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nAnimationTime {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimationTime_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nAnimationTime_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nNumAttacks {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nNumAttacks_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nNumAttacks_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nActionType {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nActionType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidTarget {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTarget_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTarget_get(swigCPtr);
      return ret;
    } 
  }

  public int m_bActionRetargettable {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_bActionRetargettable_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_bActionRetargettable_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nInventorySlot {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nInventorySlot_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nInventorySlot_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidTargetRepository {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTargetRepository_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_oidTargetRepository_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nRepositoryX {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryX_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryX_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nRepositoryY {
    set {
      NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryY_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CNWSCombatRoundAction_m_nRepositoryY_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSCombatRoundAction() : this(NWNXLibPINVOKE.new_CNWSCombatRoundAction(), true) {
  }

  public int SaveData(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSCombatRoundAction_SaveData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadData(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CNWSCombatRoundAction_LoadData(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

}

}
