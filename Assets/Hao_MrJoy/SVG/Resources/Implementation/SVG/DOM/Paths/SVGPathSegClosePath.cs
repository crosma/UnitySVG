using UnityEngine;

public class SVGPathSegClosePath : SVGPathSeg, ISVGDrawableSeg {
  private float _x = 0f;
  private float _y = 0f;
  //================================================================================
  public SVGPathSegClosePath(float x, float y) : base() {
    if(x == -1f && y == -1f) {
      this._x = previousPoint.x;
      this._y = previousPoint.y;
    } else {
      this._x = x;
      this._y = y;
    }
  }
  //================================================================================
  public override Vector2 currentPoint {
    get {
      return new Vector2(this._x, this._y);
    }
  }
  //--------------------------------------------------------------------------------
  //Method: Render
  //--------------------------------------------------------------------------------
  public void Render(SVGGraphicsPath _graphicsPath) {
    Vector2 p;
    p = currentPoint;
    _graphicsPath.AddLineTo(p);
  }
}
