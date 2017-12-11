namespace SingletonPattern
{
class LoadBalancer
{
    private static LoadBalancer _instance;
    private LoadBalancer()
    {

    }

    public static LoadBalancer GetLoadBalancer ()
    {
        if (_instance==null)
        {
          if (_instance == null)
          {
            _instance = new LoadBalancer();
          }
        }
      
 
      return _instance;

    }
    
}

}