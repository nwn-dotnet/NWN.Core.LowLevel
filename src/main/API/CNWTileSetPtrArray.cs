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

public unsafe class CNWTileSetPtrArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  public CNWTileSetPtrArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  public CNWTileSetPtrArray(void* cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, (global::System.IntPtr)cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSetPtrArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSetPtrArray() {
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
          NWNXLibPINVOKE.delete_CNWTileSetPtrArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public CNWTileSet this[int index] {
    get {
      return GetItem(index);
    }
    set {
      SetItem(index, value);
    }
  }

  public System.IntPtr Pointer {
    get {
      return swigCPtr.Handle;
    }
  }

  public static implicit operator void*(CNWTileSetPtrArray self) {
    return (void*)self.swigCPtr.Handle;
  }

  public static implicit operator System.IntPtr(CNWTileSetPtrArray self) {
    return self.swigCPtr.Handle;
  }

  public bool Equals(CNWTileSetPtrArray other) {
    if (ReferenceEquals(null, other)) {
      return false;
    }

    if (ReferenceEquals(this, other)) {
      return true;
    }

    return Pointer.Equals(other.Pointer);
  }

  public override bool Equals(object obj) {
    return ReferenceEquals(this, obj) || obj is CNWTileSetPtrArray other && Equals(other);
  }

  public override int GetHashCode() {
    return swigCPtr.Handle.GetHashCode();
  }

  public static bool operator ==(CNWTileSetPtrArray left, CNWTileSetPtrArray right) {
    return Equals(left, right);
  }

  public static bool operator !=(CNWTileSetPtrArray left, CNWTileSetPtrArray right) {
    return !Equals(left, right);
  }

  public CNWTileSetPtrArray(int nElements) : this(NWNXLibPINVOKE.new_CNWTileSetPtrArray(nElements), true) {
  }

  public CNWTileSet GetItem(int index) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetPtrArray_GetItem(swigCPtr, index);
    CNWTileSet ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSet(cPtr, false);
    return ret;
  }

  public void SetItem(int index, CNWTileSet value) {
    NWNXLibPINVOKE.CNWTileSetPtrArray_SetItem(swigCPtr, index, CNWTileSet.getCPtr(value));
  }

  public static CNWTileSetPtrArray FromPointer(void** ptr) {
    global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSetPtrArray_FromPointer((global::System.IntPtr)ptr);
    CNWTileSetPtrArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSetPtrArray(cPtr, false);
    return ret;
  }

}

}