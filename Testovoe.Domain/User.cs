namespace Testovoe.Domain
{
    public class Entity
    {
        public Guid Id { get; }

        public DateTime CreateOn { get; } = DateTime.UtcNow;

        public DateTime ModifeOn { get; set; }
      
    }

    public class User : Entity
    {
        public required string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public required DateOnly Birthday { get; set; }

    }
    public enum Gender
    {
        Female = 0,
        Male = 1,
        Unknown = 2
    }
}

/*
 * Guid - Guid - Уникальный идентификатор пользователя 
Login - string - Уникальный Логин (запрещены все символы кроме латинских букв и цифр), 
Password - string - Пароль(запрещены все символы кроме латинских букв и цифр), 
Name - string - Имя (запрещены все символы кроме латинских и русских букв) 
Gender - int - Пол 0 - женщина, 1 - мужчина, 2 - неизвестно 
Birthday - DateTime? - поле даты рождения может быть Null 
Admin - bool - Указание - является ли пользователь админом 
CreatedOn - DateTime - Дата создания пользователя 
CreatedBy - string - Логин Пользователя, от имени которого этот пользователь создан 
ModifiedOn - DateTime - Дата изменения пользователя 
ModifiedBy - string - Логин Пользователя, от имени которого этот пользователь изменён 
RevokedOn - DateTime- Дата удаления пользователя 
RevokedBy - string - Логин Пользователя, от имени которого этот пользователь удалён
*/
