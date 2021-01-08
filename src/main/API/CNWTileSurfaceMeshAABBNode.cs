//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NWN.Native.API {

public class CNWTileSurfaceMeshAABBNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CNWTileSurfaceMeshAABBNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CNWTileSurfaceMeshAABBNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CNWTileSurfaceMeshAABBNode() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Vector vBoundBoxMin {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMin_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMin_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public Vector vBoundBoxMax {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMax_set(swigCPtr, Vector.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_vBoundBoxMax_get(swigCPtr);
      Vector ret = (cPtr == global::System.IntPtr.Zero) ? null : new Vector(cPtr, false);
      return ret;
    } 
  }

  public int nTriangleId {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleId_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleId_get(swigCPtr);
      return ret;
    } 
  }

  public int nTriangleList {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleList_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nTriangleList_get(swigCPtr);
      return ret;
    } 
  }

  public int nDirection {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nDirection_set(swigCPtr, value);
    } 
    get {
      int ret = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_nDirection_get(swigCPtr);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshAABBNode pLeft {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pLeft_set(swigCPtr, CNWTileSurfaceMeshAABBNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pLeft_get(swigCPtr);
      CNWTileSurfaceMeshAABBNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSurfaceMeshAABBNode(cPtr, false);
      return ret;
    } 
  }

  public CNWTileSurfaceMeshAABBNode pRight {
    set {
      NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pRight_set(swigCPtr, CNWTileSurfaceMeshAABBNode.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = NWNXLibPINVOKE.CNWTileSurfaceMeshAABBNode_pRight_get(swigCPtr);
      CNWTileSurfaceMeshAABBNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new CNWTileSurfaceMeshAABBNode(cPtr, false);
      return ret;
    } 
  }

}

}