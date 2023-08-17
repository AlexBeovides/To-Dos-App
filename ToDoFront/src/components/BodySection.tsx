import '../styles/BodySection.scss';
import { ToDo } from './ToDo';

export function BodySection() {
    
    return (
      <div className={`body-section`}>
        <div className='todos-container'>
          <ToDo id={1} task='Si ya sabes lo que tienes que hacer y no lo haces, entonces estás peor que antes. Saber que se sabe lo que se sabe y que no se sabe lo que no se sabe; he aquí el verdadero saber. Cada cosa tiene su belleza, pero no todos pueden verla. Debes tener siempre fría la cabeza, caliente el corazón y larga la mano.'/> 
          <ToDo id={2} task='comprar pan' />
          {/* <ToDo task='Lorem ipsum es el texto que se usa habitualmente en diseño gráfico en demostraciones de tipografías o de borradores de diseño para probar el diseño visual antes de insertar el texto finaLorem ipsum es el texto que se usa habitualmente en diseño gráfico en demostraciones de tipografías o de borradores de diseño para probar el diseño visual antes de insertar el texto fina'/> 
          <ToDo task='Este mi amo, por mil señales, he visto que es un loco de atar, y aun también yo no le quedo en zaga, pues soy más mentecato que él, pues le sigo y le sirvo, si es verdadero el refrafán que dice: ‘Dime con quién andas, decirte he quién eres’, y el otro de ‘No con quien naces, sino con quien paces'/>
          <ToDo task='Lorem ipsum es el texto que se usa habitualmente en diseño gráfico en demostraciones de tipografías o de borradores de diseño para probar el diseño visual antes de insertar el texto finaLorem ipsum es el texto que se usa habitualmente en diseño gráfico en demostraciones de tipografías o de borradores de diseño para probar el diseño visual antes de insertar el texto fina'/> 
          <ToDo task='Este mi amo, por mil señales, he visto que es un loco de atar, y aun también yo no le quedo en zaga, pues soy más mentecato que él, pues le sigo y le sirvo, si es verdadero el refrafán que dice: ‘Dime con quién andas, decirte he quién eres’, y el otro de ‘No con quien naces, sino con quien paces'/> */}
        </div>

       

        <div className='spacer'></div>
      </div>
    )
}