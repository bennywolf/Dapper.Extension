 [TestClass]
    public class UnitTest1
    {
        //��һ�ֿ���ģʽ�����ｻ�����������ִ��
        [TestMethod]
        public void TestMethod1()
        {
            //MVC��Ŀ����ʱ������ע��Servce��Aop+Ioc
            /*
             * �������ܣ�
             *  1.���ҵ�񷽷������Զ��ύ�ع�
             *  2.ȫ���쳣���أ���־��¼����ỰSQL��������¼�ȵȣ�
             * ���ﴫ����Ϊ��
             *  1.һ��Service������з�����һ�𻥵�ʹ��һ������
             *  2.һ��Service�������һ��Service�����ֶ�����ǰSerivce����ػ����´��ݣ�������Ϊ���µ�������ִ�� 
             *  3.Service�����ύԭ����������׳��쳣���ύ��Ҳ���Ը���ҵ���ֶ�����Session.Rollback()��ɻع�
             */
            ServiceContainer.Builder(c =>
            {
                c.Register<Service>();
                //c.Register<Service2>();//���������ע��
            });
            //�������н�����Service
            var service = ServiceContainer.Resolve<Service>();
            service.test();
        }
        //�ڶ��ֿ���ģʽ�����б����������
        [TestMethod]
        public void TestMethod2()
        {
            //�����Զ��ύΪfalse
            DbSession session = SessionFactory.GetSession(true);
            session.From<T_MEMBER>().Insert(new T_MEMBER()
            {
                Balance = 20,
                Comment = "�����ֶ��ύ",
                CreateTime = DateTime.Now,
                MeAge = 20,
            });
            //session.Commit();
        }
        //
        public void TestMethod3()
        {
            DbSession session = SessionFactory.GetSession(true);
            //һ������
            session.From<T_MEMBER>().Insert(new T_MEMBER()
            {
                Balance = 20,
                Comment = "�����ֶ��ύ",
                CreateTime = DateTime.Now,
                MeAge = 20,
            });
            //��������,��ʹlistΪnull������CountΪ0Ҳ�����׳��쳣
            var list = new List<T_MEMBER>();
            session.From<T_MEMBER>().Insert(list);

            //�����޸�ָ���ֶ�
            session.From<T_MEMBER>()
                .Set(s => s.Comment, "������������С��30��")
                .Where(s => s.MeAge < 30)
                .Update();
            //���ݱ�ʶ�޸Ķ���
            var member = session.From<T_MEMBER>().Where(s => s.Id == 2).Single();
            session.From<T_MEMBER>().Update(member);
            //����ɾ��
            session.From<T_MEMBER>().Where(s => s.MeAge == 3 && s.MeCode.Like("cc")).Delete();
            //ɾ��Id��1��2��3��
            session.From<T_MEMBER>().Where(s => s.Id.In(new int[] { 1, 2, 3 })).Delete();
            //�ģ���ѯ
            session.From<T_MEMBER>().Where(s => s.Id.In(new int[] { 1, 2, 3 })).Select();
            //������ѯ��MeCode
            list = session.From<T_MEMBER>().Where(s => s.Id.In(new int[] { 1, 2, 3 })).Select(s => s.MeCode);
           
            //��̬Lamuda��ѯ+��ҳ
            var param = new { Age="",Balnce=30};
            var query = new SqlExpression<T_MEMBER>();
            query.Left();
            query.And(s=>s.Balance>30&&s.MeAge>20);
            query.Left();
            //����������ʱִ��
            query.AndThen(param.Age!=null,s=>s.MeAge==10);
            var total = 0;
            list = session.From<T_MEMBER>().Where(query).SkipPage(1,2,out total);
            //��ӡ����ִ�й��̵�SQL������������������дToString
            Debug.Write(session.Commands);

        }