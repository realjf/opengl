#version 330 core
out vec4 FragColor;

uniform vec3 viewPos;


in vec3 FragPos;
in vec3 Normal;
in vec2 TexCoords;

struct Material {
    sampler2D diffuse;
    vec3 specular;
    float shininess;
}; 

uniform Material material;

struct Light {
    vec3 position;
    vec3 ambient;
    vec3 diffuse;
    vec3 specular;

    // 点光源衰减
    float constant;
    float linear;
    float quadratic;

    // 聚光
    vec3  direction;
    float cutOff;
};

uniform Light light;


void main()
{
    // 聚光
    float theta = dot(lightDir, normalize(-light.direction));

    if(theta > light.cutOff) 
    {       
        // 执行光照计算
        // 环境光
        vec3 ambient = light.ambient * texture(material.diffuse, TexCoords).rgb;

        // 漫反射 
        vec3 norm = normalize(Normal);
        vec3 lightDir = normalize(light.position - FragPos);
        float diff = max(dot(norm, lightDir), 0.0);
        vec3 diffuse = light.diffuse * diff * texture(material.diffuse, TexCoords).rgb;


        // 镜面光
        vec3 viewDir = normalize(viewPos - FragPos);
        vec3 reflectDir = reflect(-lightDir, norm);  
        float spec = pow(max(dot(viewDir, reflectDir), 0.0), material.shininess);
        vec3 specular = light.specular * (spec * material.specular);

        // 点光源衰减
        float distance    = length(light.position - FragPos);
        float attenuation = 1.0 / (light.constant + light.linear * distance + 
                light.quadratic * (distance * distance));

        ambient  *= attenuation; 
        diffuse  *= attenuation;
        specular *= attenuation;
    
        vec3 result = ambient + diffuse + specular;
        FragColor = vec4(result, 1.0);
    }
    else  // 否则，使用环境光，让场景在聚光之外时不至于完全黑暗
        FragColor = vec4(light.ambient * vec3(texture(material.diffuse, TexCoords)), 1.0);

}
