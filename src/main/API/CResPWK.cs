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

public unsafe class CResPWK : CRes {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  public CResPWK(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResPWK_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CResPWK(void* cPtr, bool cMemoryOwn) : base(NWNXLibPINVOKE.CResPWK_SWIGUpcast((global::System.IntPtr)cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResPWK obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  protected override void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NWNXLibPINVOKE.delete_CResPWK(swigCPtr);
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

  public static unsafe implicit operator void*(CResPWK self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CResPWK self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CResPWK other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResPWK other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResPWK left, CResPWK right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResPWK left, CResPWK right) {
    return !Equals(left, right);
  }

  public int m_bLoaded {
    set {
      NWNXLibPINVOKE.CResPWK_m_bLoaded_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CResPWK_m_bLoaded_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nPWKNormalSize {
    set {
      NWNXLibPINVOKE.CResPWK_m_nPWKNormalSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResPWK_m_nPWKNormalSize_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pPWKData {
    set {
      NWNXLibPINVOKE.CResPWK_m_pPWKData_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CResPWK_m_pPWKData_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public CResPWK() : this(NWNXLibPINVOKE.new_CResPWK(), true) {
  }

  public byte* GetPWKDataPtr() { 
    System.IntPtr retVal = NWNXLibPINVOKE.CResPWK_GetPWKDataPtr(swigCPtr);
    return (byte*)retVal;
  }

  public uint GetPWKSize() {
    uint ret = NWNXLibPINVOKE.CResPWK_GetPWKSize(swigCPtr);
    return ret;
  }

  public int IsLoaded() {
    int ret = NWNXLibPINVOKE.CResPWK_IsLoaded(swigCPtr);
    return ret;
  }

  public override int OnResourceFreed() {
    int ret = NWNXLibPINVOKE.CResPWK_OnResourceFreed(swigCPtr);
    return ret;
  }

  public override int OnResourceServiced() {
    int ret = NWNXLibPINVOKE.CResPWK_OnResourceServiced(swigCPtr);
    return ret;
  }

}

}
