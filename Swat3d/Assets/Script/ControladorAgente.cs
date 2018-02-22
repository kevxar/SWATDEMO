using UnityEngine;
using System.Collections;
using UnityEngine.AI;
public class ControladorAgente : MonoBehaviour {

	private NavMeshAgent _agente;
	public Transform _destino;

	private Transform _posicaoInicial;
	public float _distancia;

	// Use this for initialization
	void Start () {
		_agente = this.gameObject.GetComponent<NavMeshAgent>();
		_posicaoInicial = this.transform;
		_agente.destination = _destino.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(_agente.hasPath.Equals(false)&&_agente.velocity.magnitude.Equals(0))
		{
			NovoDestino();
		}
	}

	public void NovoDestino()
	{
		_agente.destination = new Vector3 (Random.Range(_posicaoInicial.position.x-_distancia,_posicaoInicial.position.x+_distancia),2.5f,Random.Range(_posicaoInicial.position.z-_distancia,_posicaoInicial.position.z+_distancia));
	}
}