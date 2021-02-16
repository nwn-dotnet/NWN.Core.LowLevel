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

public unsafe class CNWSAreaGridPoint : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWSAreaGridPoint(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWSAreaGridPoint(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWSAreaGridPoint obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWSAreaGridPoint() {
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
          NWNXLibPINVOKE.delete_CNWSAreaGridPoint(swigCPtr);
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

  public static unsafe implicit operator void*(CNWSAreaGridPoint self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWSAreaGridPoint self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWSAreaGridPoint other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWSAreaGridPoint other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWSAreaGridPoint left, CNWSAreaGridPoint right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWSAreaGridPoint left, CNWSAreaGridPoint right) {
    return !Equals(left, right);
  }

  public int nX {
    set {
      NWNXLibPINVOKE.CNWSAreaGridPoint_nX_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaGridPoint_nX_get(swigCPtr);
      return ret;
    } 
  }

  public int nY {
    set {
      NWNXLibPINVOKE.CNWSAreaGridPoint_nY_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWSAreaGridPoint_nY_get(swigCPtr);
      return ret;
    } 
  }

  public CNWSAreaGridPoint() : this(NWNXLibPINVOKE.new_CNWSAreaGridPoint(), true) {
  }

}

}
