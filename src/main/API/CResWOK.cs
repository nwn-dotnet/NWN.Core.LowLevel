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

public unsafe class CResWOK : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CResWOK(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResWOK_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CResWOK(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResWOK_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResWOK obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResWOK(swigCPtr);
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

  public static unsafe implicit operator void*(CResWOK self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CResWOK self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CResWOK other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResWOK other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResWOK left, CResWOK right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResWOK left, CResWOK right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResWOK_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResWOK_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nWOKNormalSize {
    set {
      NWNXLibPINVOKE.CResWOK_m_nWOKNormalSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResWOK_m_nWOKNormalSize_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pWOKData {
    set {
      NWNXLibPINVOKE.CResWOK_m_pWOKData_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CResWOK_m_pWOKData_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public CResWOK() : this(NWNXLibPINVOKE.new_CResWOK(), true) {
  }

  public byte* GetWOKDataPtr() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CResWOK_GetWOKDataPtr(swigCPtr);
    return (byte*)retVal;
  }

  public uint GetWOKSize() {
    uint ret = NWNXLibPINVOKE.CResWOK_GetWOKSize(swigCPtr);
    return ret;
  }

  public int IsLoaded() {
    int ret = NWNXLibPINVOKE.CResWOK_IsLoaded(swigCPtr);
    return ret;
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResWOK_OnResourceFreed(swigCPtr);
    return ret;
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResWOK_OnResourceServiced(swigCPtr);
    return ret;
  }

}

}
