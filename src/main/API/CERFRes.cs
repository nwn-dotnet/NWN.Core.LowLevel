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

public unsafe class CERFRes : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CERFRes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CERFRes(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CERFRes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CERFRes() {
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
          NWNXLibPINVOKE.delete_CERFRes(swigCPtr);
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

  public static unsafe implicit operator void*(CERFRes self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CERFRes self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CERFRes other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CERFRes other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CERFRes left, CERFRes right) {
    return Equals(left, right);
  }

  public static bool operator !=(CERFRes left, CERFRes right) {
    return !Equals(left, right);
  }

  public uint m_nOffset {
    set {
      NWNXLibPINVOKE.CERFRes_m_nOffset_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CERFRes_m_nOffset_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nSize {
    set {
      NWNXLibPINVOKE.CERFRes_m_nSize_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CERFRes_m_nSize_get(swigCPtr);
      return ret;
    } 
  }

  public byte* m_pData {
    set {
      NWNXLibPINVOKE.CERFRes_m_pData_set(swigCPtr, (global::System.IntPtr)value);
    }  
    get {
        System.IntPtr retVal = NWNXLibPINVOKE.CERFRes_m_pData_get(swigCPtr); 
        return (byte*)retVal; 
    }

  }

  public CERFRes() : this(NWNXLibPINVOKE.new_CERFRes(), true) {
  }

  public int Read() {
    int ret = NWNXLibPINVOKE.CERFRes_Read(swigCPtr);
    return ret;
  }

  public int Reset() {
    int ret = NWNXLibPINVOKE.CERFRes_Reset(swigCPtr);
    return ret;
  }

  public int Write(CExoFile cOutFile, uint nTablePosition) {
    int ret = NWNXLibPINVOKE.CERFRes_Write(swigCPtr, CExoFile.getCPtr(cOutFile), nTablePosition);
    if (NWNXLibPINVOKE.SWIGPendingException.Pending) throw NWNXLibPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
