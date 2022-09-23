public class PlayerShoot : MonoBehaviour
{
    public float shootSpeed, shootTimer;

    private bool isShooting;

    public Transform shootPos;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        isShooting = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g") && !isShooting)
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        isShooting = true;
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(shootSpeed * Time.fixedDeltaTime, 0f);

        yield return new WaitForSeconds(shootTimer);
        isShooting = false;
    }
}
