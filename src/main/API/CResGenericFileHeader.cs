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

public unsafe class CResGenericFileHeader : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CResGenericFileHeader(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CResGenericFileHeader(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CResGenericFileHeader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CResGenericFileHeader() {
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
          NWNXLibPINVOKE.delete_CResGenericFileHeader(swigCPtr);
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

  public static unsafe implicit operator void*(CResGenericFileHeader self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CResGenericFileHeader self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CResGenericFileHeader other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CResGenericFileHeader other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CResGenericFileHeader left, CResGenericFileHeader right) {
    return Equals(left, right);
  }

  public static bool operator !=(CResGenericFileHeader left, CResGenericFileHeader right) {
    return !Equals(left, right);
  }

  public uint m_nFileType {
    set {
      NWNXLibPINVOKE.CResGenericFileHeader_m_nFileType_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGenericFileHeader_m_nFileType_get(swigCPtr);
      return ret;
    } 
  }

  public uint m_nVersion {
    set {
      NWNXLibPINVOKE.CResGenericFileHeader_m_nVersion_set(swigCPtr, value);
    } 
    get {
      uint ret = NWNXLibPINVOKE.CResGenericFileHeader_m_nVersion_get(swigCPtr);
      return ret;
    } 
  }

  public CResGenericFileHeader() : this(NWNXLibPINVOKE.new_CResGenericFileHeader(), true) {
  }

}

}
