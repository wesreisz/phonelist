using System;
using System.Collections.Generic;
using phone.core.Models;

namespace phone.core.Services
{
    public interface IService
    {
        ICollection<PhoneModel> listPhones();
        ICollection<PhoneModel> listPhonesByUser(decimal applicantId);
        PhoneModel getPhoneById(decimal phoneId);
        ICollection<PhoneCodeModel> getPhoneCds();
    }
}
