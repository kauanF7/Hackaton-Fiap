# Hackaton-Fiap

![image](https://github.com/user-attachments/assets/20490bb7-d6f8-4923-bd84-223d61cc0e02)

[Uploading Arquitetura_Hackaton.drawio…]()<mxfile modified="2024-07-25T00:02:53.987Z" host="Electron" agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) draw.io/24.6.4 Chrome/124.0.6367.207 Electron/30.0.6 Safari/537.36" etag="cE4o3I_Wx0lH24s0ZIJR" version="24.6.4" type="device">
  <diagram id="Ht1M8jgEwFfnCIfOTk4-" name="Page-1">
    <mxGraphModel dx="2193" dy="1045" grid="0" gridSize="10" guides="1" tooltips="1" connect="1" arrows="1" fold="1" page="0" pageScale="1" pageWidth="1169" pageHeight="827" math="0" shadow="0">
      <root>
        <mxCell id="0" />
        <mxCell id="1" parent="0" />
        <mxCell id="x3glNKGtr6xptLmcVaUo-6" value="AWS Cloud" style="sketch=0;outlineConnect=0;gradientColor=none;html=1;whiteSpace=wrap;fontSize=12;fontStyle=0;shape=mxgraph.aws4.group;grIcon=mxgraph.aws4.group_aws_cloud;strokeColor=#AAB7B8;fillColor=none;verticalAlign=top;align=left;spacingLeft=30;fontColor=#AAB7B8;dashed=0;" vertex="1" parent="1">
          <mxGeometry x="-43" y="123" width="1368" height="1554" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-73" value="Armazenamento/Controle de prontuario" style="rounded=1;arcSize=10;dashed=1;fillColor=#f5f5f5;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#666666;fontSize=15;verticalAlign=bottom;fontColor=#333333;" parent="1" vertex="1">
          <mxGeometry x="903.88" y="871.5" width="346.77" height="185.5" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-68" value="SNS/SQS, Database (RDS), &#xa;Amazon S3&#xa;" style="rounded=1;arcSize=10;dashed=1;fillColor=#ffe6cc;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#d79b00;fontSize=15;verticalAlign=bottom;" parent="1" vertex="1">
          <mxGeometry x="553" y="897" width="210" height="506.75" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-60" value="Serviço de teleconsulta&#xa;(Chime SDK, Lambda)&#xa;" style="rounded=1;arcSize=10;dashed=1;fillColor=#f5f5f5;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#666666;fontSize=15;verticalAlign=bottom;fontColor=#333333;" parent="1" vertex="1">
          <mxGeometry x="553" y="743.75" width="210" height="130" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-58" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-54" target="Xd43hxw84t1pM2Dfqqx2-57" edge="1">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="790.65" y="837" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-54" value="Step Functions" style="rounded=1;arcSize=10;dashed=1;fillColor=#fff2cc;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#d6b656;fontSize=15;verticalAlign=bottom;" parent="1" vertex="1">
          <mxGeometry x="830.65" y="707" width="420" height="140" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-52" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-50" target="Xd43hxw84t1pM2Dfqqx2-48" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-53" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-50" target="Xd43hxw84t1pM2Dfqqx2-51" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-50" value="Lambda Functions" style="rounded=1;arcSize=10;dashed=1;fillColor=#e1d5e7;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#9673a6;fontSize=15;verticalAlign=bottom;" parent="1" vertex="1">
          <mxGeometry x="830.65" y="467" width="420" height="230" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-49" value="Cognito" style="rounded=1;arcSize=10;dashed=1;fillColor=#d5e8d4;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#82b366;fontSize=15;" parent="1" vertex="1">
          <mxGeometry x="830.65" y="257" width="420" height="200" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-17" value="" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0.5;exitDx=0;exitDy=0;exitPerimeter=0;flowAnimation=1;" parent="1" source="x3glNKGtr6xptLmcVaUo-1" target="n6bXlb2U01Kpy1gXMiU8-2" edge="1">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="50" y="58" as="sourcePoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-21" value="" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;flowAnimation=1;" parent="1" source="n6bXlb2U01Kpy1gXMiU8-2" target="n6bXlb2U01Kpy1gXMiU8-3" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="n6bXlb2U01Kpy1gXMiU8-2" value="AWS CloudFront" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.cloudfront;fillColor=#F58536;gradientColor=none;fontSize=15;" parent="1" vertex="1">
          <mxGeometry x="161.46999999999994" y="140" width="63.63" height="63" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-23" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;flowAnimation=1;" parent="1" source="n6bXlb2U01Kpy1gXMiU8-3" edge="1">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="70" y="340" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-28" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;flowAnimation=1;" parent="1" source="n6bXlb2U01Kpy1gXMiU8-3" edge="1">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="520" y="340" as="targetPoint" />
          </mxGeometry>
        </mxCell>
        <mxCell id="n6bXlb2U01Kpy1gXMiU8-3" value="Load Balancer (ELB)" style="verticalLabelPosition=bottom;html=1;verticalAlign=top;strokeWidth=1;align=center;outlineConnect=0;dashed=0;outlineConnect=0;shape=mxgraph.aws3d.elasticLoadBalancing;fillColor=#ECECEC;strokeColor=#5E5E5E;aspect=fixed;fontSize=15;horizontal=1;" parent="1" vertex="1">
          <mxGeometry x="269.99999999999994" y="230.91" width="60.7" height="58.17" as="geometry" />
        </mxCell>
        <mxCell id="n6bXlb2U01Kpy1gXMiU8-5" value="Auto Scaling" style="rounded=1;arcSize=10;dashed=1;fillColor=#dae8fc;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#6c8ebf;fontSize=15;" parent="1" vertex="1">
          <mxGeometry x="15.35" y="350" width="570" height="127" as="geometry" />
        </mxCell>
        <mxCell id="n6bXlb2U01Kpy1gXMiU8-6" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;ECS - Serviço Paciente&lt;/font&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.ecs;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="456" y="371.25" width="72" height="67.5" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-1" value="&lt;span style=&quot;font-size: 14px;&quot;&gt;Gerenciamento de agenda&lt;/span&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.lambda_function;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="910.65" y="496.0799999999999" width="40" height="40" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-4" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;ECS - Serviço Médico&lt;/font&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.ecs;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="65.35" y="371.25" width="72" height="67.5" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-29" value="&lt;div style=&quot;font-size: 14px;&quot;&gt;Autenticação Médico&lt;/div&gt;&lt;div style=&quot;font-size: 14px;&quot;&gt;&lt;br&gt;&lt;/div&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.cognito;fillColor=#AD688B;gradientColor=none;fontSize=14;" parent="1" vertex="1">
          <mxGeometry x="900.65" y="357" width="60" height="63" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-30" value="&lt;div style=&quot;font-size: 14px;&quot;&gt;Autenticação Paciente&lt;/div&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.cognito;fillColor=#AD688B;gradientColor=none;fontSize=14;horizontal=1;" parent="1" vertex="1">
          <mxGeometry x="1108.88" y="357" width="60" height="63" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-33" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-4" target="Xd43hxw84t1pM2Dfqqx2-29" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="180" y="405" />
              <mxPoint x="180" y="550" />
              <mxPoint x="777" y="550" />
              <mxPoint x="777" y="388" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-35" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0.5;entryY=0;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="n6bXlb2U01Kpy1gXMiU8-6" target="Xd43hxw84t1pM2Dfqqx2-30" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="492" y="520" />
              <mxPoint x="731" y="520" />
              <mxPoint x="731" y="327" />
              <mxPoint x="1139" y="327" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-36" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Pesquisa de Médicos&lt;/font&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.lambda_function;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="1118.88" y="496.0799999999999" width="40" height="40" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-39" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-29" target="Xd43hxw84t1pM2Dfqqx2-1" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="1020.6500000000001" y="389" />
              <mxPoint x="1020.6500000000001" y="516" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-40" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-30" target="Xd43hxw84t1pM2Dfqqx2-36" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="1230.65" y="389" />
              <mxPoint x="1230.65" y="516" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-41" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Aceita/Recusa Consulta&lt;/font&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.lambda_function;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="910.65" y="587" width="40" height="40" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-42" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;Agendamento/Cancelamento&lt;/font&gt;&lt;div&gt;&lt;font style=&quot;font-size: 14px;&quot;&gt;Consulta&lt;/font&gt;&lt;/div&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.lambda_function;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="1118.88" y="587" width="40" height="40" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-45" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-1" target="Xd43hxw84t1pM2Dfqqx2-41" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="800.65" y="516" />
              <mxPoint x="800.65" y="607" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-47" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-36" target="Xd43hxw84t1pM2Dfqqx2-42" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="1050.65" y="516.0799999999999" />
              <mxPoint x="1050.65" y="607" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-48" value="SAGA Coordinator" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.step_functions;fillColor=#D9A741;gradientColor=none;fontSize=14;" parent="1" vertex="1">
          <mxGeometry x="920.65" y="737" width="50" height="53" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-51" value="SAGA Coordinator" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.step_functions;fillColor=#D9A741;gradientColor=none;fontSize=14;" parent="1" vertex="1">
          <mxGeometry x="1113.88" y="737" width="50" height="53" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-55" value="" style="sketch=0;points=[[0,0,0],[0.25,0,0],[0.5,0,0],[0.75,0,0],[1,0,0],[0,1,0],[0.25,1,0],[0.5,1,0],[0.75,1,0],[1,1,0],[0,0.25,0],[0,0.5,0],[0,0.75,0],[1,0.25,0],[1,0.5,0],[1,0.75,0]];outlineConnect=0;fontColor=#232F3E;fillColor=#DD344C;strokeColor=#ffffff;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;fontSize=12;fontStyle=0;aspect=fixed;shape=mxgraph.aws4.resourceIcon;resIcon=mxgraph.aws4.chime_sdk;" parent="1" vertex="1">
          <mxGeometry x="572.35" y="753.75" width="48" height="48" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-57" value="" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.lambda_function;fillColor=#F58534;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="673" y="757.75" width="40" height="40" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-59" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-57" target="Xd43hxw84t1pM2Dfqqx2-55" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-64" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0.48;exitDx=0;exitDy=0;exitPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-61" target="Xd43hxw84t1pM2Dfqqx2-63" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="583" y="960.75" />
              <mxPoint x="583" y="1113.75" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-61" value="Serviço de notificação&lt;br&gt;teleconsulta" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.sns;fillColor=#D9A741;gradientColor=none;fontSize=15;" parent="1" vertex="1">
          <mxGeometry x="628" y="933.75" width="60" height="56.5" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-62" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0.5;entryY=0;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-60" target="Xd43hxw84t1pM2Dfqqx2-61" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-63" value="Database (RDS)" style="sketch=0;outlineConnect=0;fontColor=#232F3E;gradientColor=none;strokeColor=#ffffff;fillColor=#232F3E;dashed=0;verticalLabelPosition=middle;verticalAlign=bottom;align=center;html=1;whiteSpace=wrap;fontSize=10;fontStyle=1;spacing=3;shape=mxgraph.aws4.productIcon;prIcon=mxgraph.aws4.rds;" parent="1" vertex="1">
          <mxGeometry x="618" y="1063.75" width="80" height="100" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-65" value="Storage (S3)&amp;nbsp;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.s3;fillColor=#E05243;gradientColor=none;fontSize=14;" parent="1" vertex="1">
          <mxGeometry x="628" y="1203.75" width="63" height="73" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-67" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-63" target="Xd43hxw84t1pM2Dfqqx2-65" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="718" y="1113.75" />
              <mxPoint x="718" y="1240.75" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-72" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-69" target="Xd43hxw84t1pM2Dfqqx2-71" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-69" value="&lt;font style=&quot;font-size: 14px;&quot;&gt;S3&lt;/font&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.s3;fillColor=#E05243;gradientColor=none;" parent="1" vertex="1">
          <mxGeometry x="1015.6500000000001" y="906" width="50" height="61" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-70" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0.5;entryY=0;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-54" target="Xd43hxw84t1pM2Dfqqx2-69" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-71" value="Amazon DynamoDB" style="sketch=0;outlineConnect=0;fontColor=#232F3E;gradientColor=none;strokeColor=#ffffff;fillColor=#232F3E;dashed=0;verticalLabelPosition=middle;verticalAlign=bottom;align=center;html=1;whiteSpace=wrap;fontSize=10;fontStyle=1;spacing=3;shape=mxgraph.aws4.productIcon;prIcon=mxgraph.aws4.dynamodb;" parent="1" vertex="1">
          <mxGeometry x="1168.88" y="917" width="60" height="89" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-74" value="SNS/SQS, Database (RDS), &#xa;Amazon S3&#xa;" style="rounded=1;arcSize=10;dashed=1;fillColor=#ffe6cc;dashPattern=8 3 1 3;strokeWidth=2;strokeColor=#d79b00;fontSize=15;verticalAlign=bottom;" parent="1" vertex="1">
          <mxGeometry x="990.6500000000001" y="1117" width="210" height="523.5" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-75" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0;exitY=0.48;exitDx=0;exitDy=0;exitPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-76" target="Xd43hxw84t1pM2Dfqqx2-77" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="1020.6500000000001" y="1160.75" />
              <mxPoint x="1020.6500000000001" y="1313.75" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-76" value="Serviço de notificação&lt;div&gt;prontuario&lt;/div&gt;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.sns;fillColor=#D9A741;gradientColor=none;fontSize=15;" parent="1" vertex="1">
          <mxGeometry x="1065.65" y="1133.75" width="60" height="56.5" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-77" value="Database (RDS)" style="sketch=0;outlineConnect=0;fontColor=#232F3E;gradientColor=none;strokeColor=#ffffff;fillColor=#232F3E;dashed=0;verticalLabelPosition=middle;verticalAlign=bottom;align=center;html=1;whiteSpace=wrap;fontSize=10;fontStyle=1;spacing=3;shape=mxgraph.aws4.productIcon;prIcon=mxgraph.aws4.rds;" parent="1" vertex="1">
          <mxGeometry x="1055.65" y="1263.75" width="80" height="100" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-78" value="Storage (S3)&amp;nbsp;" style="outlineConnect=0;dashed=0;verticalLabelPosition=bottom;verticalAlign=top;align=center;html=1;shape=mxgraph.aws3.s3;fillColor=#E05243;gradientColor=none;fontSize=14;" parent="1" vertex="1">
          <mxGeometry x="1065.65" y="1403.75" width="63" height="73" as="geometry" />
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-79" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=1;entryY=0.5;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-77" target="Xd43hxw84t1pM2Dfqqx2-78" edge="1">
          <mxGeometry relative="1" as="geometry">
            <Array as="points">
              <mxPoint x="1155.65" y="1313.75" />
              <mxPoint x="1155.65" y="1440.75" />
            </Array>
          </mxGeometry>
        </mxCell>
        <mxCell id="Xd43hxw84t1pM2Dfqqx2-80" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;entryX=0.41;entryY=-0.004;entryDx=0;entryDy=0;entryPerimeter=0;flowAnimation=1;" parent="1" source="Xd43hxw84t1pM2Dfqqx2-73" target="Xd43hxw84t1pM2Dfqqx2-74" edge="1">
          <mxGeometry relative="1" as="geometry" />
        </mxCell>
        <mxCell id="x3glNKGtr6xptLmcVaUo-1" value="Paciente" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;outlineConnect=0;" vertex="1" parent="1">
          <mxGeometry x="35.35000000000002" y="20" width="30" height="60" as="geometry" />
        </mxCell>
        <mxCell id="x3glNKGtr6xptLmcVaUo-2" value="Médico" style="shape=umlActor;verticalLabelPosition=bottom;verticalAlign=top;html=1;outlineConnect=0;" vertex="1" parent="1">
          <mxGeometry x="330.70000000000005" y="20" width="30" height="60" as="geometry" />
        </mxCell>
        <mxCell id="x3glNKGtr6xptLmcVaUo-5" value="" style="edgeStyle=orthogonalEdgeStyle;rounded=0;orthogonalLoop=1;jettySize=auto;html=1;exitX=0.5;exitY=0.5;exitDx=0;exitDy=0;exitPerimeter=0;flowAnimation=1;" edge="1" parent="1" source="x3glNKGtr6xptLmcVaUo-2">
          <mxGeometry relative="1" as="geometry">
            <mxPoint x="50" y="58" as="sourcePoint" />
            <mxPoint x="193" y="140" as="targetPoint" />
          </mxGeometry>
        </mxCell>
      </root>
    </mxGraphModel>
  </diagram>
</mxfile>



Contaremos com o **Amazon CloudFront** para garantir uma distribuição rápida e segura de conteúdo, melhorando significativamente a performance e reduzindo a latência globalmente. 

Utilizaremos um **Lambda** para autenticação de usuário pois oferece vantagens significativas. Pois sendo um serviço serverless, elimina a necessidade de gerenciar a infraestrutura, garantindo escalabilidade automática e reduzindo custos operacionais. Lambdas lidam bem com picos de tráfego, proporcionando baixa latência e uma experiência fluida ao usuário. Além disso, permitem implementar medidas de segurança robustas, como validação de tokens e verificação de permissões, garantindo a proteção dos dados.

Como parte da arquitetura, implementaremos um **API Gateway** para internalizar as requisições, encaminhando-as para um **Load Balancer** que distribui o tráfego entre os containers da API de forma balanceada. 

Optamos por **ECS Fargate** devido à facilidade de configuração e à rápida escalabilidade parametrizável. Inicialmente configuraremos duas tasks operando 24/7, com a capacidade de escalar até 15 tasks conforme necessário. Para escalar, definiremos métricas de CPU e memória para garantir um dimensionamento eficiente e adequado dos recursos do sistema. Essas métricas nos permitirão monitorar o uso dos recursos em tempo real e ajustar dinamicamente a capacidade conforme necessário, assegurando que tenhamos sempre o desempenho ideal e evitando sub ou super utilização dos recursos.

Para gerenciar o fluxo de agendamento e cadastro, escolhemos o **DynamoDB** devido à sua natureza de banco de dados não relacional, permitindo armazenar objetos complexos contendo todas as agendas disponíveis e reservadas dos médicos, assim como informações de prontuários. 

Além disso, implementaremos um segundo banco de dados **MySQL** para gerenciar os cadastros de usuários, aproveitando a facilidade de relacionamento entre tabelas e a alta performance em escalas maiores. Essas escolhas foram feitas com o objetivo de otimizar a eficiência operacional e a capacidade de resposta do sistema, garantindo uma experiência robusta e confiável para os usuários finais.

E quase finalizando temos como proposta a utilização do **Amazon SES** que é uma solução confiável e escalável para enviar e-mails de maneira eficiente. Ele garante alta taxa de entrega e baixa chance de ser marcado como spam, oferecendo personalização através de templates e integração simples com o ECS.

Para finalizar, todos os prontuários e receituarios serão armazenados de forma segura dentro de um **bucket S3**. O acesso aos prontuários será controlado por políticas de permissão rigorosas, garantindo que apenas médicos autorizados possam baixar os prontuários dos pacientes.

##  Fluxograma do Sistema - Médico
![image](https://github.com/user-attachments/assets/9761794e-c10d-4a92-a39e-b5d2ce818251)
![image](https://github.com/user-attachments/assets/8721f792-952c-465c-a057-8c39fd2d5736)
![image](https://github.com/user-attachments/assets/acc2abf1-a595-43b5-9fa9-9c9580610a8c)

##  Fluxograma do Sistema - Paciente
![image](https://github.com/user-attachments/assets/20aad976-fb06-402e-8510-386ac617aaf4)




## 👨‍💻 Integrantes
Edgar Santos,
Kauan Falcão,
Leandro Carvalho,
Rodolfo Azevedo,
Marcel Leme

@2024
