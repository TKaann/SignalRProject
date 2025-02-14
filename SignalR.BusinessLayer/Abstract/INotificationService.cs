﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;


namespace SignalR.BusinessLayer.Abstract
{
	public interface INotificationService:IGenericService<Notification>
	{
		int TNotificationCountByStatusFalse();
		List<Notification> TGetAllNotificationByFalse();
        void TNotificationStatusChangeToTrue(int id);
        void TNotificationStatusChangeToFalse(int id);
    }
}
