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

public unsafe class CScriptTalent : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CScriptTalent(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CScriptTalent(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CScriptTalent obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CScriptTalent() {
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
          NWNXLibPINVOKE.delete_CScriptTalent(swigCPtr);
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

  public static unsafe implicit operator void*(CScriptTalent self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CScriptTalent self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CScriptTalent other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CScriptTalent other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CScriptTalent left, CScriptTalent right) {
    return Equals(left, right);
  }

  public static bool operator !=(CScriptTalent left, CScriptTalent right) {
    return !Equals(left, right);
  }

  public int m_nType {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_nType_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptTalent_m_nType_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nID {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_nID_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptTalent_m_nID_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMultiClass {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_nMultiClass_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CScriptTalent_m_nMultiClass_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_oidItem {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_oidItem_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CScriptTalent_m_oidItem_get(swigCPtr);
      return ret;
    } 
  }

  public int m_nItemPropertyIndex {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_nItemPropertyIndex_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CScriptTalent_m_nItemPropertyIndex_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nCasterLevel {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_nCasterLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CScriptTalent_m_nCasterLevel_get(swigCPtr);
      return ret;
    } 
  }

  public byte m_nMetaType {
    set {
      NWNXLibPINVOKE.CScriptTalent_m_nMetaType_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.CScriptTalent_m_nMetaType_get(swigCPtr);
      return ret;
    } 
  }

  public CScriptTalent() : this(NWNXLibPINVOKE.new_CScriptTalent(), true) {
  }

  public void CopyScriptTalent(CScriptTalent pTalent) {
    NWNXLibPINVOKE.CScriptTalent_CopyScriptTalent(swigCPtr, CScriptTalent.getCPtr(pTalent));
  }

  public int _Equals(CScriptTalent pTalent) {
    int ret = NWNXLibPINVOKE.CScriptTalent__Equals(swigCPtr, CScriptTalent.getCPtr(pTalent));
    return ret;
  }

  public int SaveTalent(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CScriptTalent_SaveTalent(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

  public int LoadTalent(CResGFF pRes, CResStruct pStruct) {
    int ret = NWNXLibPINVOKE.CScriptTalent_LoadTalent(swigCPtr, CResGFF.getCPtr(pRes), CResStruct.getCPtr(pStruct));
    return ret;
  }

}

}
