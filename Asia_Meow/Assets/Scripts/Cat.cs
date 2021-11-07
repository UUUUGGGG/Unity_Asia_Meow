using UnityEngine;       //�ޥ� unity �����R�W�Ŷ� : �i�H�ϥΦ��Ŷ� API

// ������
//class ���O:�@�Ӫ����Ź�
//�y�k: ���O ���O�W�� { ���O���e ( ���O���� ) }
// �����O�n�bUnity ���ϥΥ����~�� MonBehaviour
public class Cat : MonoBehaviour
{
    #region ���y�k�Υ|�j�`������
    //��� Field :�O�s�U�����������
    //�y�k: �׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // �|�j�`������:
    //��  ��: �x�s�S���p���I�����t��� - int
    //�B�I��: �x�s���a�p���I�����t��� - float
    //�r  ��: �x�s��r��T           - string
    //���L��: �O�P�_ ture or false   - bool
    // �׹���
    // �p�H: ��L���O����s�� ����� (�w�]��) private 
    // ���}: ��L���O�i�H�s�� ��� public
    // ����ݩ� Attritube
    // �y�k : [�ݩʦW��(��)]
    // 1.���D Header (�r��)
    // 2.���� Tooltip (�r��)
    // 3.�d�� Range (�̤p�� �̤j��)
    public int cc = 1000;
    [Range(1, 10)]
    public float weight = 3.5f;
    [Tooltip("�o�O�߿ߪ��W��")]
    public string brand = "�p�p";
    [Header("�O�_���ѵ�")]
    public bool hasSkywindow = false;
    #endregion

    #region Unity���������
    // �C�� �V�q(�y��) ���� �C������ ����
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCustom1 = new Color(0, 0, 1);
    public Color colorCustom2 = new Color(1, 0, 1, 0.5f);
    //�V�q 2-4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2right = Vector2.right;
    public Vector2 v2custom = new Vector2(1, 2);
    //���� Keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.A;
    public KeyCode keycodeMouseRight = KeyCode.D;
    public KeyCode keycodeJump = KeyCode.Space;
    // �C������ Gameobject
    public GameObject goCamera;
    public GameObject goCar;
    // ����
    public Transform tranCamera;
    public Camera cam;
    public SpriteRenderer spr;
    #endregion

    #region �ƥ� : �{�����J�f
    //�}�l�ƥ� : �C������ɰ���@��
    private void Start()
    {
        //�I�s��k : ��k�W��();
        Test();
        Run5();
        Run10();
        Run(15); //�I�s�ɶ�J�٬� : �޼�
        float w99 = ConverWeight(9.9f);
        print("9.9 �ഫ :" + w99);

        print("���q�ഫ :" + ConverWeight(weight));
    }
    #endregion

    #region ��k�P�y�k
    //��k : �O�s�{�����e���϶� �t��k ���z��
    //�y�k : �׹��� �Ǧ^���� ��k�W�� (�Ѽ�1 �Ѽ�2 ����L��) {�{�����e}
    //void �L�Ǧ^ : �ϥΤ�k�ɤ��|���Ǧ^���
    private void Test()
    {
        //��X(�T��) - �N�T����X��unity �����O Console
        print("���O�A�ڬO�p�p:)");
    }

    private void Run5()
    {
        print("�]�B�t�� : " + 5);
        print("���� : �p�p�p");
    }
    private void Run10()
    {
        print("�]�B�t�� : " + 10);
        print("���� : �p�p�p");
    }

    //�Ѽƻy�k : ������� �ѼƦW��
    private void Run(int speed)
    {
        print("�]�B�t�� : " + speed);
        print("���� : �p�p�p");
    }

    private float ConverWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}