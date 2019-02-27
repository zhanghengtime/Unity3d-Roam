var scrollSpeed : float = 0.5;

function Update () {
var offset : float = Time.time * scrollSpeed;
renderer.material.SetTextureOffset ("_MainTex", Vector2(offset,0));
}