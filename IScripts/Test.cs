   // 测试脚本,不可直接使用,仅供参考;
   // IUICenterOnChild 为脚本文件名;

    IUICenterOnChild mCenterChild ;
    if (mCenterChild)
    {
            mCenterChild.onCenter += OnCenterCallback;
    }


    void OnCenterCallback(GameObject centeredObject)
    {
        mCenterItem = centeredObject;
    }


    // On click left;
    void OnClickLeft(object obj)
    {
        List<Transform> items = mgrid.GetChildList();
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].gameObject == mCenterItem)
            {
                if (i + 1 < items.Count)
                {
                    if (mCenterChild)
                    {

                        if (i + 1 == items.Count-1)
                        {
                            mCenterChild.CenterOn(items[i]);
                        }
                        else
                        {
                            mCenterChild.CenterOn(items[i + 1]);
                        }
                        break;
                    }
                }
            }
        }
      
    }

    // On click right;
    void OnClickRight(object obj)
    {
        List<Transform> items = mgrid.GetChildList();
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].gameObject == mCenterItem)
            {
                if (i - 1 >= 0)
                {
                    if (mCenterChild)
                    {
                        if(i-1==0)
                        {
                            mCenterChild.CenterOn(items[1]);
                        }
                        else
                        {
                            mCenterChild.CenterOn(items[i - 1]);
                        }
                        break;
                    }
                }
            }
        }
    }