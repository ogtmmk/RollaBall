using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DangerWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �I�u�W�F�N�g�ƐڐG�������ɌĂ΂��R�[���o�b�N
    void OnCollisionEnter(Collision hit)
    {

          // �ڐG�����I�u�W�F�N�g�̃^�O��"Player"�̏ꍇ
          if (gameObject.CompareTag("Player"))
	   {

		  // ���݂̃V�[���ԍ����擾
		  int sceneIndex = SceneManager.GetActiveScene().buildIndex;
 
		  // ���݂̃V�[�����ēǍ�����
		  SceneManager.LoadScene(sceneIndex);
	   }  
    }

}