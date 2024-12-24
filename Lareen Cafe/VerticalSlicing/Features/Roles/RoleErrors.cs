using LareenCafe.Api.VerticalSlicing.Features.FeaturesCommon;

namespace Lareen_Cafe.VerticalSlicing.Features.Roles
{
    public class RoleErrors
    {
        public static readonly Error RoleNotFound =
       new("لم يتم العثور على الدور", StatusCodes.Status404NotFound);

        public static readonly Error DuplicatedRole =
            new("هناك دور آخر بنفس الاسم موجود بالفعل", StatusCodes.Status409Conflict);

        public static readonly Error RoleAlreadyExists =
            new("الدور موجود بالفعل", StatusCodes.Status409Conflict);

        public static readonly Error UserNotAssignedToThatRole =
            new("لم يتم تعيين المستخدم لهذا الدور", StatusCodes.Status400BadRequest);

        public static readonly Error RoleNotAssigned =
           new("لم يتم تعيين الدور", StatusCodes.Status400BadRequest);
    }
}
