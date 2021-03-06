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

public unsafe class NWPlayerCharacterListClass_st : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public NWPlayerCharacterListClass_st(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public NWPlayerCharacterListClass_st(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NWPlayerCharacterListClass_st obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NWPlayerCharacterListClass_st() {
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
          NWNXLibPINVOKE.delete_NWPlayerCharacterListClass_st(swigCPtr);
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

  public static unsafe implicit operator void*(NWPlayerCharacterListClass_st self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(NWPlayerCharacterListClass_st self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(NWPlayerCharacterListClass_st other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is NWPlayerCharacterListClass_st other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(NWPlayerCharacterListClass_st left, NWPlayerCharacterListClass_st right) {
    return Equals(left, right);
  }

  public static bool operator !=(NWPlayerCharacterListClass_st left, NWPlayerCharacterListClass_st right) {
    return !Equals(left, right);
  }

  public int nClass {
    set {
      NWNXLibPINVOKE.NWPlayerCharacterListClass_st_nClass_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.NWPlayerCharacterListClass_st_nClass_get(swigCPtr);
      return ret;
    } 
  }

  public byte nClassLevel {
    set {
      NWNXLibPINVOKE.NWPlayerCharacterListClass_st_nClassLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = NWNXLibPINVOKE.NWPlayerCharacterListClass_st_nClassLevel_get(swigCPtr);
      return ret;
    } 
  }

  public NWPlayerCharacterListClass_st() : this(NWNXLibPINVOKE.new_NWPlayerCharacterListClass_st(), true) {
  }

}

}
