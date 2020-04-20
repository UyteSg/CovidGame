using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class CameraControl : MonoBehaviour {

	[Range(0, 10f)]
	public float moveSpeed = 10f;

	[Range(0, 5f)]
	public float sensitivity = 3;
	public bool isDragging { get; private set; }

	public new Camera camera { get; private set; }

	private float  tempSens;
	private Vector2 tempCenter, targetDirection, tempMousePos;

	private void Start() {
		this.camera = GetComponent<Camera>();
	}

	private void Update() {
		UpdateInput();
		UpdatePosition();
	}

	private void UpdateInput() {Vector2 mousePosition = Input.mousePosition;
		if (Input.GetMouseButtonDown(0)){
			OnPointDown(mousePosition);
		}
		else if (Input.GetMouseButtonUp(0)){
			OnPointUp(mousePosition);
		}
		else if (Input.GetMouseButton(0)){
			OnPointMove(mousePosition);
		}
	}
	private void UpdatePosition() {
		float speed = Time.deltaTime * this.moveSpeed;	// скорость перемещения исп дельту задержки
		if(this.isDragging){
			this.tempSens = this.sensitivity;	// текущая чувствительность мыши
		}
		else{
			this.tempSens = Mathf.Lerp(this.tempSens, 0f, speed);
		}
		Vector2 newPosition = (Vector2)this.transform.position + (Vector2)this.targetDirection * this.tempSens;
		this.transform.position = Vector2.Lerp(this.transform.position, newPosition, speed);
	}

	private Vector2 GetWorldPoint(Vector2 mousePosition){  //перевод экранных координат в координты сцены(мировые координаты)
		Vector2 point = Vector2.zero;
		Ray ray = this.camera.ScreenPointToRay(mousePosition);

		Vector3 normal = Vector3.forward;
		Vector3 position = Vector3.zero;
		Plane plane = new Plane(normal, position);

		float distance;
		plane.Raycast(ray, out distance);
		point = ray.GetPoint(distance);

		return point;
	}

	private void OnPointDown(Vector2 mousePosition) {
		this.tempCenter = GetWorldPoint(mousePosition);
		this.targetDirection = Vector2.zero;
		this.tempMousePos = mousePosition;
		this.isDragging = true;
	}
	private void OnPointMove(Vector2 mousePosition) {
		if(this.isDragging){
			Vector2 point = GetWorldPoint(mousePosition);	//берём текущие координты мыши
			float sqrDist = (this.tempCenter - point).sqrMagnitude; // минимальное движеие мыши для движения камеры
			if(sqrDist > 0.1f){
				this.targetDirection = (this.tempMousePos - mousePosition).normalized;
				this.tempMousePos = mousePosition;
			}
		}
	}
	private void OnPointUp(Vector2 mousePosition) {
		this.isDragging = false;
	}
}
